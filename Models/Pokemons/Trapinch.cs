using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Trapinch Species to store common natural stats of all Trapinchs
	#region SpeciesTrapinch
	public class SpeciesTrapinch : PokemonSpecies
	{
#nullable enable
		private static SpeciesTrapinch? _instance = null;
#nullable restore
        public static SpeciesTrapinch Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesTrapinch();
                }
                return _instance;
            }
        }

		#region SpeciesTrapinch Constructor
		public SpeciesTrapinch() : base(
			328,
			"Trapinch",
			0.7,
			15.0,
			45, // HPs
			100, 45, // Attack & Defense
			45, 45, // Special Attack & Defense
			10		
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
				"Gust",
				"Sand-Attack",
				"Headbutt",
				"Body-Slam",
				"Double-Edge",
				"Bite",
				"Hyper-Beam",
				"Strength",
				"Solar-Beam",
				"Earthquake",
				"Fissure",
				"Dig",
				"Toxic",
				"Quick-Attack",
				"Mimic",
				"Double-Team",
				"Focus-Energy",
				"Bide",
				"Rest",
				"Rock-Slide",
				"Substitute",
				"Snore",
				"Flail",
				"Protect",
				"Feint-Attack",
				"Mud-Slap",
				"Sandstorm",
				"Giga-Drain",
				"Endure",
				"Swagger",
				"Fury-Cutter",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Hidden-Power",
				"Sunny-Day",
				"Crunch",
				"Rock-Smash",
				"Facade",
				"Superpower",
				"Secret-Power",
				"Rock-Tomb",
				"Signal-Beam",
				"Sand-Tomb",
				"Mud-Shot",
				"Natural-Gift",
				"Feint",
				"Earth-Power",
				"Captivate",
				"Bug-Bite",
				"Round",
				"Struggle-Bug",
				"Bulldoze",
				"Confide"
			};
		}
		#endregion
	}
	#endregion

	//Trapinch PokemonInstance Class
	#region Trapinch
	public class TrapinchInstance : PokemonInstance
	{
		#region Trapinch Constructors
		/// <summary>
		/// Trapinch Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public TrapinchInstance(string nickname, int level)
		: base(
				SpeciesTrapinch.Instance, // Pokemon Species
				nickname, level,
				Ground.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Trapinch Builder only waiting for a Level
		/// </summary>
		public TrapinchInstance(int level)
		: base(
				SpeciesTrapinch.Instance, // PokemonInstance Species
				"Trapinch", level,
				Ground.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Trapinch Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public TrapinchInstance() : base(
			SpeciesTrapinch.Instance, // PokemonInstance Species
			Ground.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}