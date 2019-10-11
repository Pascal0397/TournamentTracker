using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary.Models
{
   public class MatchupEntryModel
   {
        /// <summary>
        /// Represents one Team in the Matchup.
        /// </summary>
        public TeamModel TeamCompeting { get; set; }

        /// <summary>
        /// Represents the score for this particular Team.
        /// </summary>
        public double Score { get; set; }

        /// <summary>
        /// Represents the Matchup that this team came 
        /// from as the winner.
        /// </summary>
        public MatchupModel ParentMatchup { get; set; }

    }
}
