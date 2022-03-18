using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Oshawott Species to store common natural stats of all Oshawotts
	#region SpeciesOshawott
	public class SpeciesOshawott : PokemonSpecies
	{
#nullable enable
		private static SpeciesOshawott? _instance = null;
#nullable restore
        public static SpeciesOshawott Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesOshawott();
                }
                return _instance;
            }
        }

		#region SpeciesOshawott Constructor
		public SpeciesOshawott() : base(
			501,
			"Oshawott",
			0.5,
			5.9,
			55, // HPs
			55, 45, // Attack & Defense
			63, 45, // Special Attack & Defense
			45		
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
				"Screech",
				"Double-Team",
				"Focus-Energy",
				"Waterfall",
				"Rest",
				"Substitute",
				"Snore",
				"Protect",
				"Icy-Wind",
				"Detect",
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
				"Brine",
				"Assurance",
				"Fling",
				"Trump-Card",
				"Copycat",
				"Night-Slash",
				"Aqua-Tail",
				"Air-Slash",
				"X-Scissor",
				"Grass-Knot",
				"Aqua-Jet",
				"Round",
				"Scald",
				"Retaliate",
				"Water-Pledge",
				"Work-Up",
				"Sacred-Sword",
				"Razor-Shell",
				"Confide"
			};
		}
		#endregion
	}
	#endregion

	//Oshawott PokemonInstance Class
	#region Oshawott
	public class OshawottInstance : PokemonInstance
	{
		#region Oshawott Constructors
		/// <summary>
		/// Oshawott Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public OshawottInstance(string nickname, int level)
		: base(
				SpeciesOshawott.Instance, // Pokemon Species
				nickname, level,
				Water.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Oshawott Builder only waiting for a Level
		/// </summary>
		public OshawottInstance(int level)
		: base(
				SpeciesOshawott.Instance, // PokemonInstance Species
				"Oshawott", level,
				Water.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Oshawott Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public OshawottInstance() : base(
			SpeciesOshawott.Instance, // PokemonInstance Species
			Water.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}