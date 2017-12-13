using System;
using System.Threading.Tasks;
using FSI.ClientMgmtTool.Backend.Foundation.DatabaseContext.Entities;
using Microsoft.EntityFrameworkCore;

namespace FSI.ClientMgmtTool.Backend.Foundation.DatabaseContext
{
    public class CustomFieldParser
    {
        /// <summary>
        /// the database
        /// </summary>
        private FoundationContext Db { get; }

        /// <summary>
        /// the unqiue Id
        /// </summary>
        private int UnqiueId { get; }

        /// <summary>
        /// the company no
        /// </summary>
        private int CompanyNo { get; }

        /// <summary>
        /// the company id
        /// </summary>
        private string CompanyId { get; }
        public CustomFieldParser(FoundationContext db, int uniqueId, int companyNo, string companyId)
        {
            Db = db;
            UnqiueId = uniqueId;
            CompanyNo = companyNo;
            CompanyId = companyId;
        }

        /// <summary>
        /// parses the string
        /// </summary>
        /// <param name="field">the field to parse it from</param>
        /// <returns>the string</returns>
        public async Task<string> ParseString(CustomField field)
        {
            return await CustomData(field, x => x);
        }

        /// <summary>
        /// parse a date
        /// </summary>
        /// <param name="field"></param>
        /// <returns></returns>
        public async Task<DateTime> ParseDate(CustomField field)
        {
            return await CustomData(field, x =>
            {
                if (x == null)
                {
                    return DateTime.MinValue;
                }

                return DateTime.Parse(x);
            });
        }

        public async Task<decimal> ParseDecimal(CustomField field)
        {
            return await CustomData(field, decimal.Parse);
        }
        public async Task<T> CustomData<T>(CustomField field,
            Func<string, T> parseFunc)
        {
            var result = await CustomData(field);

            return parseFunc(result.NewColValue);
        }
        /// <summary>
        /// loads the custom data field for the given id
        /// </summary>
        /// <param name="field">the field</param>
        /// <returns>the custom data field</returns>
        public async Task<UdfNewColData> CustomData(CustomField field)
        {
            return await Db.UdfNewColData.FirstOrDefaultAsync(x => x.RowUniqueId == UnqiueId &&
                                                                   x.TableNumber == field.TableNumber && x.NewColSeq ==
                                                                   field.ColumnSequence);
        }

        /// <summary>
        /// inserts a date into the database
        /// </summary>
        /// <param name="field"></param>
        /// <param name="value"></param>
        /// <returns></returns>
        public async Task InsertDate(CustomField field, DateTime value)
        {
            await InsertRecord(field, value, x => x.ToString());
        }
        /// <summary>
        /// maps value and inserts it in database
        /// </summary>
        /// <typeparam name="T">type to insert</typeparam>
        /// <param name="field">field to insert</param>
        /// <param name="value">value to insert</param>
        /// <param name="mapper">mapping function</param>
        /// <returns>void</returns>
        public async Task InsertRecord<T>(CustomField field, T value, Func<T, string> mapper)
        {
            var toInsert = mapper(value);
            await InsertRecord(field, toInsert);
        }
        /// <summary>
        /// added insert record function
        /// </summary>
        /// <param name="field">the field to insert</param>
        /// <param name="value">the value to insert</param>
        /// <returns>void</returns>
        public async Task InsertRecord(CustomField field, string value)
        {
            var record = await CustomData(field);

            if (record == null)
            {
                record = new UdfNewColData
                {
                    CompanyNo = CompanyNo,
                    TableNumber = field.TableNumber,
                    NewColSeq = field.ColumnSequence,
                    RowUniqueId = UnqiueId,
                    CompanyId = CompanyId
                };

                await Db.UdfNewColData.AddAsync(record);
            }

            record.NewColValue = value;

            await Db.SaveChangesAsync();
        }
    }
}
