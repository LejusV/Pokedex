using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Dewott Species to store common natural stats of all Dewotts
	#region SpeciesDewott
	public class SpeciesDewott : PokemonSpecies
	{
#nullable enable
		private static SpeciesDewott? _instance = null;
#nullable restore
        public static SpeciesDewott Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesDewott();
                }
                return _instance;
            }
        }

		#region SpeciesDewott Constructor
		public SpeciesDewott() : base(
			502,
			"Dewott",
			0.8,
			24.5,
			75, // HPs
			75, 60, // Attack & Defense
			83, 60, // Special Attack & Defense
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
				"Swords-Dance",
				"Cut",
				"Tackle",
				"Tail-Whip",
				"Water-Gun",
				"Hydro-Pump",
				"Surf",
				"Ice-Beam",
				"Blizzard",
				"Dig",
				"Toxic",
				"Double-Team",
				"Focus-Energy",
				"Waterfall",
				"Rest",
				"Substitute",
				"Snore",
				"Protect",
				"Icy-Wind",
				"False-Swipe",
				"Swagger",
				"Fury-Cutter",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Encore",
				"Iron-Tail",
				"Hidden-Power",
				"Rain-Dance",
				"Rock-Smash",
				"Hail",
				"Facade",
				"Taunt",
				"Helping-Hand",
				"Revenge",
				"Secret-Power",
				"Dive",
				"Aerial-Ace",
				"Covet",
				"Water-Sport",
				"Water-Pulse",
				"Fling",
				"Aqua-Tail",
				"X-Scissor",
				"Grass-Knot",
				"Aqua-Jet",
				"Round",
				"Scald",
				"Retaliate",
				"Water-Pledge",
				"Work-Up",
				"Razor-Shell",
				"Confide"
			};
		}
		#endregion
	}
	#endregion

	//Dewott PokemonInstance Class
	#region Dewott
	public class DewottInstance : PokemonInstance
	{
		#region Dewott Constructors
		/// <summary>
		/// Dewott Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public DewottInstance(string nickname, int level)
		: base(
				SpeciesDewott.Instance, // Pokemon Species
				nickname, level,
				Water.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Dewott Builder only waiting for a Level
		/// </summary>
		public DewottInstance(int level)
		: base(
				SpeciesDewott.Instance, // PokemonInstance Species
				"Dewott", level,
				Water.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Dewott Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public DewottInstance() : base(
			SpeciesDewott.Instance, // PokemonInstance Species
			Water.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}