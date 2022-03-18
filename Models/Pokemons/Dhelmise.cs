using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Dhelmise Species to store common natural stats of all Dhelmises
	#region SpeciesDhelmise
	public class SpeciesDhelmise : PokemonSpecies
	{
#nullable enable
		private static SpeciesDhelmise? _instance = null;
#nullable restore
        public static SpeciesDhelmise Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesDhelmise();
                }
                return _instance;
            }
        }

		#region SpeciesDhelmise Constructor
		public SpeciesDhelmise() : base(
			781,
			"Dhelmise",
			3.9,
			210.0,
			70, // HPs
			131, 100, // Attack & Defense
			86, 90, // Special Attack & Defense
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
				"Swords-Dance",
				"Slam",
				"Wrap",
				"Surf",
				"Hyper-Beam",
				"Absorb",
				"Mega-Drain",
				"Growth",
				"Solar-Beam",
				"Earthquake",
				"Toxic",
				"Double-Team",
				"Rest",
				"Rock-Slide",
				"Substitute",
				"Thief",
				"Protect",
				"Giga-Drain",
				"Swagger",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Rapid-Spin",
				"Hidden-Power",
				"Rain-Dance",
				"Sunny-Day",
				"Shadow-Ball",
				"Whirlpool",
				"Facade",
				"Brick-Break",
				"Astonish",
				"Metal-Sound",
				"Aerial-Ace",
				"Gyro-Ball",
				"Payback",
				"Embargo",
				"Energy-Ball",
				"Switcheroo",
				"Giga-Impact",
				"Shadow-Claw",
				"Flash-Cannon",
				"Power-Whip",
				"Grass-Knot",
				"Sludge-Wave",
				"Heavy-Slam",
				"Round",
				"Bulldoze",
				"Phantom-Force",
				"Confide",
				"Anchor-Shot",
				"Brutal-Swing"
			};
		}
		#endregion
	}
	#endregion

	//Dhelmise PokemonInstance Class
	#region Dhelmise
	public class DhelmiseInstance : PokemonInstance
	{
		#region Dhelmise Constructors
		/// <summary>
		/// Dhelmise Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public DhelmiseInstance(string nickname, int level)
		: base(
				SpeciesDhelmise.Instance, // Pokemon Species
				nickname, level,
				Ghost.Instance, Grass.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Dhelmise Builder only waiting for a Level
		/// </summary>
		public DhelmiseInstance(int level)
		: base(
				SpeciesDhelmise.Instance, // PokemonInstance Species
				"Dhelmise", level,
				Ghost.Instance, Grass.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Dhelmise Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public DhelmiseInstance() : base(
			SpeciesDhelmise.Instance, // PokemonInstance Species
			Ghost.Instance, Grass.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}