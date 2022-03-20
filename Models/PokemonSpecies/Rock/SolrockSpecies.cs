using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Solrock Species to store common natural stats of all Solrocks
	#region SolrockSpecies
	public class SolrockSpecies : PokemonSpecies
	{
#nullable enable
		private static SolrockSpecies? _instance = null;
#nullable restore
        public static SolrockSpecies Instance => _instance ?? (_instance = new SolrockSpecies());

		#region SolrockSpecies Constructor
		public SolrockSpecies() : base(
			338,
			"Solrock",
			Rock.Instance, Psychic.Instance,
			1.2,
			154.0,
			new PokemonStats(
				90, // HPs
				95, 85, // Attack & Defense
				55, 65, // Spacial Attack & Defense
				70 // Speed
			)			
		)
		{
			InitMovesList();
		}
		#endregion

		#region Methods
		private void InitMovesList()
		{
			_moveList = new List<string>()
			{
				"Tackle",
				"Body-Slam",
				"Double-Edge",
				"Flamethrower",
				"Hyper-Beam",
				"Solar-Beam",
				"Fire-Spin",
				"Rock-Throw",
				"Earthquake",
				"Toxic",
				"Confusion",
				"Psychic",
				"Mimic",
				"Double-Team",
				"Harden",
				"Defense-Curl",
				"Light-Screen",
				"Reflect",
				"Self-Destruct",
				"Fire-Blast",
				"Swift",
				"Dream-Eater",
				"Flash",
				"Psywave",
				"Explosion",
				"Rest",
				"Rock-Slide",
				"Substitute",
				"Snore",
				"Protect",
				"Sandstorm",
				"Endure",
				"Rollout",
				"Swagger",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Safeguard",
				"Pain-Split",
				"Hidden-Power",
				"Sunny-Day",
				"Psych-Up",
				"Ancient-Power",
				"Shadow-Ball",
				"Heat-Wave",
				"Will-O-Wisp",
				"Facade",
				"Helping-Hand",
				"Magic-Coat",
				"Recycle",
				"Skill-Swap",
				"Secret-Power",
				"Overheat",
				"Rock-Tomb",
				"Cosmic-Power",
				"Signal-Beam",
				"Iron-Defense",
				"Calm-Mind",
				"Gravity",
				"Gyro-Ball",
				"Natural-Gift",
				"Embargo",
				"Heal-Block",
				"Flare-Blitz",
				"Rock-Polish",
				"Earth-Power",
				"Giga-Impact",
				"Zen-Headbutt",
				"Trick-Room",
				"Iron-Head",
				"Stone-Edge",
				"Stealth-Rock",
				"Grass-Knot",
				"Charge-Beam",
				"Wonder-Room",
				"Psyshock",
				"Telekinesis",
				"Smack-Down",
				"Round",
				"Incinerate",
				"Acrobatics",
				"Bulldoze",
				"Confide"
			};
		}
		#endregion
	}
	#endregion
}