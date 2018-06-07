using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Com.Wiseape.Framework;
using Com.Wiseape.Common.Data.Model;
using Com.Wiseape.Common.Data.Context;
using Com.Wiseape.Common.Resources.Repository.Contract;

namespace Com.Wiseape.Common.Resources.Repository.Service
{
    /// <summary>
    /// Repository for LanguageKeyword data.
    /// </summary>
    public class FindLanguageKeywordRepository : BaseRepository<LanguageKeyword>, IFindLanguageKeywordRepository
    {
        class Keywords
        {
            public static string FindLanguageKeyword = "Find.Common.Resources.LanguageKeyword";
        }

        /// <summary>
        /// Constructor for LanguageKeywordRepository
        /// </summary>
        /// <param name="dataContextKey">Key for Datacontext to use</param>
        public FindLanguageKeywordRepository(string dataContextKey) : base(dataContextKey)
        {
        }
        
        
        public FindLanguageKeywordRepository()
        {
            this.DataContextKey = Keywords.FindLanguageKeyword;
        }

//------------------- Find by keywords --------------------------------------------------------

        /// <summary>
        /// Finds all  Language Keyword data with keyword containing specified keyword
        /// </summary>
		/// <param name="keyword"> Keyword</param>
		/// <returns>List of  Language Keyword</returns>
        public List<LanguageKeyword> FindByKeyword(string keyword)
        {
            CommonDataContext dataContext = (CommonDataContext)this.DataContext;
            var list = from o in dataContext.LanguageKeywords
                       where
							o.Keyword.Contains(keyword) 						
						select o;
            return list.ToList();
        }

        /// <summary>
        /// Finds all  Language Keyword data with keyword Text containing specified keyword
        /// </summary>
		/// <param name="keywordText"> Keyword Text</param>
		/// <returns>List of  Language Keyword</returns>
        public List<LanguageKeyword> FindByKeywordText(string keywordText)
        {
            CommonDataContext dataContext = (CommonDataContext)this.DataContext;
            var list = from o in dataContext.LanguageKeywords
                       where
							o.KeywordText.Contains(keywordText) 						
						select o;
            return list.ToList();
        }

        /// <summary>
        /// Finds all  Language Keyword data with language I D containing specified keyword
        /// </summary>
		/// <param name="languageID"> Language I D</param>
		/// <returns>List of  Language Keyword</returns>
        public List<LanguageKeyword> FindByLanguageID(string languageID)
        {
            CommonDataContext dataContext = (CommonDataContext)this.DataContext;
            var list = from o in dataContext.LanguageKeywords
                       where
							o.LanguageID.Contains(languageID) 						
						select o;
            return list.ToList();
        }


//----------------------  find by dates -----------------------------------------------


//-----------------------  Find by Foreign keys ---------------------------------------




    }
}
