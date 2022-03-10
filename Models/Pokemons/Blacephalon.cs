using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Blacephalon Species to store common natural stats of all Blacephalons
	#region SpeciesBlacephalon
	public class SpeciesBlacephalon : PokemonSpecies
	{
#nullable enable
		private static SpeciesBlacephalon? _instance = null;
#nullable restore
        public static SpeciesBlacephalon Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesBlacephalon();
                }
                return _instance;
            }
        }

		#region SpeciesBlacephalon Constructor
		public SpeciesBlacephalon() : base(
			"Blacephalon",
			1.8,
			13.0,
			53, // HPs
			127, 53, // Attack & Defense
			151, 79, // Special Attack & Defense
			107		
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
				"Ember",
				"Flamethrower",
				"Hyper-Beam",
				"Toxic",
				"Psychic",
				"Night-Shade",
				"Double-Team",
				"Light-Screen",
				"Fire-Blast",
				"Explosion",
				"Rest",
				"Substitute",
				"Thief",
				"Protect",
				"Swagger",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Hidden-Power",
				"Sunny-Day",
				"Shadow-Ball",
				"Torment",
				"Will-O-Wisp",
				"Facade",
				"Taunt",
				"Trick",
				"Magic-Coat",
				"Astonish",
				"Overheat",
				"Calm-Mind",
				"Payback",
				"Fling",
				"Dark-Pulse",
				"Shadow-Claw",
				"Psyshock",
				"Smack-Down",
				"Flame-Burst",
				"Flame-Charge",
				"Round",
				"Stored-Power",
				"Quash",
				"Confide",
				"Mind-Blown"
			};
		}
		#endregion
	}
	#endregion

	//Blacephalon PokemonInstance Class
	#region Blacephalon
	public class BlacephalonInstance : PokemonInstance
	{
		#region Blacephalon Constructors
		/// <summary>
		/// Blacephalon Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public BlacephalonInstance(string nickname, int level)
		: base(
				806,
				SpeciesBlacephalon.Instance, // Pokemon Species
				nickname, level,
				Fire.Instance, Ghost.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Blacephalon Builder only waiting for a Level
		/// </summary>
		public BlacephalonInstance(int level)
		: base(
				806,
				SpeciesBlacephalon.Instance, // PokemonInstance Species
				"Blacephalon", level,
				Fire.Instance, Ghost.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Blacephalon Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public Blacephalon() : base(
			806,
			SpeciesBlacephalon.Instance, // PokemonInstance Species
			Fire.Instance, Ghost.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}