using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Brionne Species to store common natural stats of all Brionnes
	#region SpeciesBrionne
	public class SpeciesBrionne : PokemonSpecies
	{
#nullable enable
		private static SpeciesBrionne? _instance = null;
#nullable restore
        public static SpeciesBrionne Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesBrionne();
                }
                return _instance;
            }
        }

		#region SpeciesBrionne Constructor
		public SpeciesBrionne() : base(
			729,
			"Brionne",
			0.6,
			17.5,
			60, // HPs
			69, 69, // Attack & Defense
			91, 81, // Special Attack & Defense
			50		
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
				"Rest",
				"Substitute",
				"Protect",
				"Icy-Wind",
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
				"Captivate",
				"Aqua-Jet",
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
				"Baby-Doll-Eyes"
			};
		}
		#endregion
	}
	#endregion

	//Brionne PokemonInstance Class
	#region Brionne
	public class BrionneInstance : PokemonInstance
	{
		#region Brionne Constructors
		/// <summary>
		/// Brionne Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public BrionneInstance(string nickname, int level)
		: base(
				SpeciesBrionne.Instance, // Pokemon Species
				nickname, level,
				Water.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Brionne Builder only waiting for a Level
		/// </summary>
		public BrionneInstance(int level)
		: base(
				SpeciesBrionne.Instance, // PokemonInstance Species
				"Brionne", level,
				Water.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Brionne Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public BrionneInstance() : base(
			SpeciesBrionne.Instance, // PokemonInstance Species
			Water.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}