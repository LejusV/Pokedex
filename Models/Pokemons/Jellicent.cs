using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Jellicent Species to store common natural stats of all Jellicents
	#region SpeciesJellicent
	public class SpeciesJellicent : PokemonSpecies
	{
#nullable enable
		private static SpeciesJellicent? _instance = null;
#nullable restore
        public static SpeciesJellicent Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesJellicent();
                }
                return _instance;
            }
        }

		#region SpeciesJellicent Constructor
		public SpeciesJellicent() : base(
			"Jellicent",
			2.2,
			135.0,
			100, // HPs
			60, 70, // Attack & Defense
			85, 105, // Special Attack & Defense
			60		
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
				"Hydro-Pump",
				"Surf",
				"Ice-Beam",
				"Blizzard",
				"Bubble-Beam",
				"Hyper-Beam",
				"Absorb",
				"Toxic",
				"Psychic",
				"Night-Shade",
				"Double-Team",
				"Recover",
				"Waterfall",
				"Dream-Eater",
				"Bubble",
				"Flash",
				"Rest",
				"Substitute",
				"Snore",
				"Spite",
				"Protect",
				"Sludge-Bomb",
				"Icy-Wind",
				"Giga-Drain",
				"Swagger",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Safeguard",
				"Pain-Split",
				"Hidden-Power",
				"Rain-Dance",
				"Psych-Up",
				"Shadow-Ball",
				"Hail",
				"Will-O-Wisp",
				"Facade",
				"Taunt",
				"Trick",
				"Magic-Coat",
				"Secret-Power",
				"Dive",
				"Water-Spout",
				"Water-Sport",
				"Shock-Wave",
				"Water-Pulse",
				"Brine",
				"Wring-Out",
				"Dark-Pulse",
				"Energy-Ball",
				"Giga-Impact",
				"Trick-Room",
				"Ominous-Wind",
				"Sludge-Wave",
				"Round",
				"Scald",
				"Hex",
				"Confide",
				"Dazzling-Gleam"
			};
		}
		#endregion
	}
	#endregion

	//Jellicent PokemonInstance Class
	#region Jellicent
	public class JellicentInstance : PokemonInstance
	{
		#region Jellicent Constructors
		/// <summary>
		/// Jellicent Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public JellicentInstance(string nickname, int level)
		: base(
				593,
				SpeciesJellicent.Instance, // Pokemon Species
				nickname, level,
				Water.Instance, Ghost.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Jellicent Builder only waiting for a Level
		/// </summary>
		public JellicentInstance(int level)
		: base(
				593,
				SpeciesJellicent.Instance, // PokemonInstance Species
				"Jellicent", level,
				Water.Instance, Ghost.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Jellicent Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public Jellicent() : base(
			593,
			SpeciesJellicent.Instance, // PokemonInstance Species
			Water.Instance, Ghost.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}