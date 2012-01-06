using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Epi.Web.Common.BusinessObject;

namespace Epi.Web.Interfaces.DataInterfaces
{
    /// <summary>
    /// Defines methods to access SurveyInfos.
    /// </summary>
    /// <remarks>
    /// This is a database-independent interface. Implementations are database specific.
    /// </remarks>
    public interface ISurveyInfoDao
    {
        /// <summary>
        /// Gets a specific SurveyInfo.
        /// </summary>
        /// <param name="SurveyInfoId">Unique SurveyInfo identifier.</param>
        /// <returns>SurveyInfo.</returns>
        List<SurveyInfoBO> GetSurveyInfo(List<string> SurveyInfoId);

        /// <summary>
        /// Gets a sorted list of all SurveyInfos.
        /// </summary>
        /// <param name="sortExpression">Sort order.</param>
        /// <returns>Sorted list of SurveyInfos.</returns>
       // List<SurveyInfoBO> GetSurveyInfos(string sortExpression = "SurveyInfoId ASC");
        
        /// <summary>
        /// Gets SurveyInfo given an order.
        /// </summary>
        /// <param name="orderId">Unique order identifier.</param>
        /// <returns>SurveyInfo.</returns>
       // SurveyInfoBO GetSurveyInfoByOrder(int orderId);

        /// <summary>
        /// Gets SurveyInfos with order statistics in given sort order.
        /// </summary>
        /// <param name="SurveyInfos">SurveyInfo list.</param>
        /// <param name="sortExpression">Sort order.</param>
        /// <returns>Sorted list of SurveyInfos with order statistics.</returns>
     //   List<SurveyInfoBO> GetSurveyInfosWithOrderStatistics(string sortExpression);

        /// <summary>
        /// Inserts a new SurveyInfo. 
        /// </summary>
        /// <remarks>
        /// Following insert, SurveyInfo object will contain the new identifier.
        /// </remarks>
        /// <param name="SurveyInfo">SurveyInfo.</param>
       void InsertSurveyInfo(SurveyInfoBO SurveyInfo);

        /// <summary>
        /// Updates a SurveyInfo.
        /// </summary>
        /// <param name="SurveyInfo">SurveyInfo.</param>
        void UpdateSurveyInfo(SurveyInfoBO SurveyInfo);

        /// <summary>
        /// Deletes a SurveyInfo
        /// </summary>
        /// <param name="SurveyInfo">SurveyInfo.</param>
         void DeleteSurveyInfo(SurveyInfoBO SurveyInfo);
    }
}
