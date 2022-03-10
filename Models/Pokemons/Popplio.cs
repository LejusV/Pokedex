using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Popplio Species to store common natural stats of all Popplios
	#region SpeciesPopplio
	public class SpeciesPopplio : PokemonSpecies
	{
#nullable enable
		private static SpeciesPopplio? _instance = null;
#nullable restore
        public static SpeciesPopplio Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesPopplio();
                }
                return _instance;
            }
        }

		#region SpeciesPopplio Constructor
		public SpeciesPopplio() : base(
			"Popplio",
			0.4,
			7.5,
			50, // HPs
			54, 54, // Attack & Defense
			66, 56, // Special Attack & Defense
			40		
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
				"Pound",
				"Double-Slap",
				"Growl",
				"Sing",
				"Water-Gun",
				"Hydro-Pump",
				"Surf",
				"Ice-Beam",
				"Blizzard",
				"Bubble-Beam",
				"Toxic",
				"Double-Team",
				"Waterfall",
				"Amnesia",
				"Rest",
				"Substitute",
				"Protect",
				"Perish-Song",
				"Icy-Wind",
				"Charm",
				"Swagger",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Encore",
				"Hidden-Power",
				"Rain-Dance",
				"Hail",
				"Facade",
				"Hyper-Voice",
				"Aqua-Ring",
				"Captivate",
				"Aqua-Jet",
				"Wonder-Room",
				"Round",
				"Echoed-Voice",
				"Scald",
				"Acrobatics",
				"Water-Pledge",
				"Work-Up",
				"Disarming-Voice",
				"Misty-Terrain",
				"Moonblast",
				"Confide",
				"Aromatic-Mist",
				"Baby-Doll-Eyes"
			};
		}
		#endregion
	}
	#endregion

	//Popplio PokemonInstance Class
	#region Popplio
	public class PopplioInstance : PokemonInstance
	{
		#region Popplio Constructors
		/// <summary>
		/// Popplio Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public PopplioInstance(string nickname, int level)
		: base(
				728,
				SpeciesPopplio.Instance, // Pokemon Species
				nickname, level,
				Water.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Popplio Builder only waiting for a Level
		/// </summary>
		public PopplioInstance(int level)
		: base(
				728,
				SpeciesPopplio.Instance, // PokemonInstance Species
				"Popplio", level,
				Water.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Popplio Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public Popplio() : base(
			728,
			SpeciesPopplio.Instance, // PokemonInstance Species
			Water.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}