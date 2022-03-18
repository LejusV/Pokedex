using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Girafarig Species to store common natural stats of all Girafarigs
	#region SpeciesGirafarig
	public class SpeciesGirafarig : PokemonSpecies
	{
#nullable enable
		private static SpeciesGirafarig? _instance = null;
#nullable restore
        public static SpeciesGirafarig Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesGirafarig();
                }
                return _instance;
            }
        }

		#region SpeciesGirafarig Constructor
		public SpeciesGirafarig() : base(
			203,
			"Girafarig",
			1.5,
			41.5,
			70, // HPs
			80, 65, // Attack & Defense
			90, 65, // Special Attack & Defense
			85		
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
				"Razor-Wind",
				"Stomp",
				"Double-Kick",
				"Headbutt",
				"Tackle",
				"Body-Slam",
				"Take-Down",
				"Double-Edge",
				"Growl",
				"Psybeam",
				"Strength",
				"Thunderbolt",
				"Thunder-Wave",
				"Thunder",
				"Earthquake",
				"Toxic",
				"Confusion",
				"Psychic",
				"Agility",
				"Mimic",
				"Double-Team",
				"Light-Screen",
				"Reflect",
				"Swift",
				"Amnesia",
				"Dream-Eater",
				"Flash",
				"Rest",
				"Substitute",
				"Thief",
				"Nightmare",
				"Snore",
				"Curse",
				"Protect",
				"Mud-Slap",
				"Zap-Cannon",
				"Foresight",
				"Endure",
				"Swagger",
				"Mean-Look",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Baton-Pass",
				"Iron-Tail",
				"Hidden-Power",
				"Rain-Dance",
				"Sunny-Day",
				"Crunch",
				"Mirror-Coat",
				"Psych-Up",
				"Shadow-Ball",
				"Future-Sight",
				"Rock-Smash",
				"Beat-Up",
				"Uproar",
				"Facade",
				"Trick",
				"Wish",
				"Magic-Coat",
				"Recycle",
				"Skill-Swap",
				"Secret-Power",
				"Hyper-Voice",
				"Astonish",
				"Odor-Sleuth",
				"Signal-Beam",
				"Calm-Mind",
				"Shock-Wave",
				"Gravity",
				"Natural-Gift",
				"Assurance",
				"Power-Swap",
				"Guard-Swap",
				"Sucker-Punch",
				"Energy-Ball",
				"Nasty-Plot",
				"Zen-Headbutt",
				"Trick-Room",
				"Captivate",
				"Grass-Knot",
				"Charge-Beam",
				"Double-Hit",
				"Psyshock",
				"Telekinesis",
				"Foul-Play",
				"Round",
				"Echoed-Voice",
				"Retaliate",
				"Bulldoze",
				"Work-Up",
				"Confide",
				"Dazzling-Gleam",
				"Psychic-Terrain",
				"Psychic-Fangs"
			};
		}
		#endregion
	}
	#endregion

	//Girafarig PokemonInstance Class
	#region Girafarig
	public class GirafarigInstance : PokemonInstance
	{
		#region Girafarig Constructors
		/// <summary>
		/// Girafarig Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public GirafarigInstance(string nickname, int level)
		: base(
				SpeciesGirafarig.Instance, // Pokemon Species
				nickname, level,
				Normal.Instance, Psychic.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Girafarig Builder only waiting for a Level
		/// </summary>
		public GirafarigInstance(int level)
		: base(
				SpeciesGirafarig.Instance, // PokemonInstance Species
				"Girafarig", level,
				Normal.Instance, Psychic.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Girafarig Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public GirafarigInstance() : base(
			SpeciesGirafarig.Instance, // PokemonInstance Species
			Normal.Instance, Psychic.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}