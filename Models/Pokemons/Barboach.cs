using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Barboach Species to store common natural stats of all Barboachs
	#region SpeciesBarboach
	public class SpeciesBarboach : PokemonSpecies
	{
#nullable enable
		private static SpeciesBarboach? _instance = null;
#nullable restore
        public static SpeciesBarboach Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesBarboach();
                }
                return _instance;
            }
        }

		#region SpeciesBarboach Constructor
		public SpeciesBarboach() : base(
			339,
			"Barboach",
			0.4,
			1.9,
			50, // HPs
			48, 43, // Attack & Defense
			46, 41, // Special Attack & Defense
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
				"Headbutt",
				"Take-Down",
				"Thrash",
				"Double-Edge",
				"Water-Gun",
				"Hydro-Pump",
				"Surf",
				"Ice-Beam",
				"Blizzard",
				"Earthquake",
				"Fissure",
				"Toxic",
				"Mimic",
				"Double-Team",
				"Waterfall",
				"Amnesia",
				"Rest",
				"Substitute",
				"Snore",
				"Flail",
				"Protect",
				"Mud-Slap",
				"Icy-Wind",
				"Sandstorm",
				"Endure",
				"Swagger",
				"Spark",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Magnitude",
				"Hidden-Power",
				"Rain-Dance",
				"Future-Sight",
				"Whirlpool",
				"Hail",
				"Facade",
				"Secret-Power",
				"Dive",
				"Mud-Sport",
				"Rock-Tomb",
				"Muddy-Water",
				"Bounce",
				"Mud-Shot",
				"Water-Sport",
				"Dragon-Dance",
				"Water-Pulse",
				"Natural-Gift",
				"Aqua-Tail",
				"Earth-Power",
				"Mud-Bomb",
				"Captivate",
				"Round",
				"Scald",
				"Bulldoze",
				"Confide"
			};
		}
		#endregion
	}
	#endregion

	//Barboach PokemonInstance Class
	#region Barboach
	public class BarboachInstance : PokemonInstance
	{
		#region Barboach Constructors
		/// <summary>
		/// Barboach Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public BarboachInstance(string nickname, int level)
		: base(
				SpeciesBarboach.Instance, // Pokemon Species
				nickname, level,
				Water.Instance, Ground.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Barboach Builder only waiting for a Level
		/// </summary>
		public BarboachInstance(int level)
		: base(
				SpeciesBarboach.Instance, // PokemonInstance Species
				"Barboach", level,
				Water.Instance, Ground.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Barboach Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public BarboachInstance() : base(
			SpeciesBarboach.Instance, // PokemonInstance Species
			Water.Instance, Ground.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}