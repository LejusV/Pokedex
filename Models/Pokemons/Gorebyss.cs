using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Gorebyss Species to store common natural stats of all Gorebysss
	#region SpeciesGorebyss
	public class SpeciesGorebyss : PokemonSpecies
	{
#nullable enable
		private static SpeciesGorebyss? _instance = null;
#nullable restore
        public static SpeciesGorebyss Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesGorebyss();
                }
                return _instance;
            }
        }

		#region SpeciesGorebyss Constructor
		public SpeciesGorebyss() : base(
			368,
			"Gorebyss",
			1.8,
			22.6,
			55, // HPs
			84, 105, // Attack & Defense
			114, 75, // Special Attack & Defense
			52		
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
				"Bind",
				"Body-Slam",
				"Double-Edge",
				"Hydro-Pump",
				"Surf",
				"Ice-Beam",
				"Blizzard",
				"Hyper-Beam",
				"Toxic",
				"Confusion",
				"Psychic",
				"Agility",
				"Mimic",
				"Double-Team",
				"Waterfall",
				"Swift",
				"Amnesia",
				"Rest",
				"Substitute",
				"Snore",
				"Protect",
				"Mud-Slap",
				"Icy-Wind",
				"Endure",
				"Swagger",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Safeguard",
				"Baton-Pass",
				"Hidden-Power",
				"Rain-Dance",
				"Psych-Up",
				"Shadow-Ball",
				"Whirlpool",
				"Hail",
				"Facade",
				"Secret-Power",
				"Dive",
				"Signal-Beam",
				"Bounce",
				"Water-Sport",
				"Water-Pulse",
				"Brine",
				"Natural-Gift",
				"Aqua-Ring",
				"Aqua-Tail",
				"Giga-Impact",
				"Captivate",
				"Coil",
				"Round",
				"Scald",
				"Draining-Kiss",
				"Confide",
				"Infestation"
			};
		}
		#endregion
	}
	#endregion

	//Gorebyss PokemonInstance Class
	#region Gorebyss
	public class GorebyssInstance : PokemonInstance
	{
		#region Gorebyss Constructors
		/// <summary>
		/// Gorebyss Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public GorebyssInstance(string nickname, int level)
		: base(
				SpeciesGorebyss.Instance, // Pokemon Species
				nickname, level,
				Water.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Gorebyss Builder only waiting for a Level
		/// </summary>
		public GorebyssInstance(int level)
		: base(
				SpeciesGorebyss.Instance, // PokemonInstance Species
				"Gorebyss", level,
				Water.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Gorebyss Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public GorebyssInstance() : base(
			SpeciesGorebyss.Instance, // PokemonInstance Species
			Water.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}