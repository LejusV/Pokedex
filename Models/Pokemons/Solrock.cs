using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Solrock Species to store common natural stats of all Solrocks
	#region SpeciesSolrock
	public class SpeciesSolrock : PokemonSpecies
	{
#nullable enable
		private static SpeciesSolrock? _instance = null;
#nullable restore
        public static SpeciesSolrock Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesSolrock();
                }
                return _instance;
            }
        }

		#region SpeciesSolrock Constructor
		public SpeciesSolrock() : base(
			"Solrock",
			1.2,
			154.0,
			90, // HPs
			95, 85, // Attack & Defense
			55, 65, // Special Attack & Defense
			70		
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

	//Solrock PokemonInstance Class
	#region Solrock
	public class SolrockInstance : PokemonInstance
	{
		#region Solrock Constructors
		/// <summary>
		/// Solrock Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public SolrockInstance(string nickname, int level)
		: base(
				338,
				SpeciesSolrock.Instance, // Pokemon Species
				nickname, level,
				Rock.Instance, Psychic.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Solrock Builder only waiting for a Level
		/// </summary>
		public SolrockInstance(int level)
		: base(
				338,
				SpeciesSolrock.Instance, // PokemonInstance Species
				"Solrock", level,
				Rock.Instance, Psychic.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Solrock Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public Solrock() : base(
			338,
			SpeciesSolrock.Instance, // PokemonInstance Species
			Rock.Instance, Psychic.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}