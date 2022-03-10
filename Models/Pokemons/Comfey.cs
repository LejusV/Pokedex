using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Comfey Species to store common natural stats of all Comfeys
	#region SpeciesComfey
	public class SpeciesComfey : PokemonSpecies
	{
#nullable enable
		private static SpeciesComfey? _instance = null;
#nullable restore
        public static SpeciesComfey Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesComfey();
                }
                return _instance;
            }
        }

		#region SpeciesComfey Constructor
		public SpeciesComfey() : base(
			"Comfey",
			0.1,
			0.3,
			51, // HPs
			52, 90, // Attack & Defense
			82, 110, // Special Attack & Defense
			100		
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
				"Vine-Whip",
				"Wrap",
				"Hyper-Beam",
				"Leech-Seed",
				"Growth",
				"Solar-Beam",
				"Petal-Dance",
				"Toxic",
				"Double-Team",
				"Light-Screen",
				"Amnesia",
				"Rest",
				"Substitute",
				"Thief",
				"Protect",
				"Sweet-Kiss",
				"Endure",
				"Swagger",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Safeguard",
				"Sweet-Scent",
				"Synthesis",
				"Hidden-Power",
				"Sunny-Day",
				"Psych-Up",
				"Facade",
				"Nature-Power",
				"Taunt",
				"Helping-Hand",
				"Aromatherapy",
				"Magical-Leaf",
				"Calm-Mind",
				"Natural-Gift",
				"U-Turn",
				"Fling",
				"Lucky-Chant",
				"Energy-Ball",
				"Trick-Room",
				"Grass-Knot",
				"After-You",
				"Round",
				"Echoed-Voice",
				"Acrobatics",
				"Petal-Blizzard",
				"Draining-Kiss",
				"Flower-Shield",
				"Grassy-Terrain",
				"Play-Rough",
				"Confide",
				"Dazzling-Gleam",
				"Floral-Healing"
			};
		}
		#endregion
	}
	#endregion

	//Comfey PokemonInstance Class
	#region Comfey
	public class ComfeyInstance : PokemonInstance
	{
		#region Comfey Constructors
		/// <summary>
		/// Comfey Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public ComfeyInstance(string nickname, int level)
		: base(
				764,
				SpeciesComfey.Instance, // Pokemon Species
				nickname, level,
				Fairy.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Comfey Builder only waiting for a Level
		/// </summary>
		public ComfeyInstance(int level)
		: base(
				764,
				SpeciesComfey.Instance, // PokemonInstance Species
				"Comfey", level,
				Fairy.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Comfey Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public Comfey() : base(
			764,
			SpeciesComfey.Instance, // PokemonInstance Species
			Fairy.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}