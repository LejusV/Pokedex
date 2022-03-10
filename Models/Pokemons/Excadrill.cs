using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Excadrill Species to store common natural stats of all Excadrills
	#region SpeciesExcadrill
	public class SpeciesExcadrill : PokemonSpecies
	{
#nullable enable
		private static SpeciesExcadrill? _instance = null;
#nullable restore
        public static SpeciesExcadrill Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesExcadrill();
                }
                return _instance;
            }
        }

		#region SpeciesExcadrill Constructor
		public SpeciesExcadrill() : base(
			"Excadrill",
			0.7,
			40.4,
			110, // HPs
			135, 60, // Attack & Defense
			50, 65, // Special Attack & Defense
			88		
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
				"Scratch",
				"Swords-Dance",
				"Cut",
				"Horn-Drill",
				"Hyper-Beam",
				"Strength",
				"Earthquake",
				"Fissure",
				"Dig",
				"Toxic",
				"Double-Team",
				"Fury-Swipes",
				"Rest",
				"Rock-Slide",
				"Slash",
				"Substitute",
				"Snore",
				"Protect",
				"Sludge-Bomb",
				"Mud-Slap",
				"Sandstorm",
				"Swagger",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Rapid-Spin",
				"Metal-Claw",
				"Hidden-Power",
				"Rock-Smash",
				"Facade",
				"Brick-Break",
				"Secret-Power",
				"Mud-Sport",
				"Rock-Tomb",
				"Aerial-Ace",
				"Iron-Defense",
				"Fling",
				"Magnet-Rise",
				"Poison-Jab",
				"X-Scissor",
				"Focus-Blast",
				"Earth-Power",
				"Giga-Impact",
				"Shadow-Claw",
				"Iron-Head",
				"Stealth-Rock",
				"Hone-Claws",
				"Round",
				"Bulldoze",
				"Drill-Run",
				"Rototiller",
				"Confide",
				"Smart-Strike",
				"Brutal-Swing"
			};
		}
		#endregion
	}
	#endregion

	//Excadrill PokemonInstance Class
	#region Excadrill
	public class ExcadrillInstance : PokemonInstance
	{
		#region Excadrill Constructors
		/// <summary>
		/// Excadrill Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public ExcadrillInstance(string nickname, int level)
		: base(
				530,
				SpeciesExcadrill.Instance, // Pokemon Species
				nickname, level,
				Ground.Instance, Steel.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Excadrill Builder only waiting for a Level
		/// </summary>
		public ExcadrillInstance(int level)
		: base(
				530,
				SpeciesExcadrill.Instance, // PokemonInstance Species
				"Excadrill", level,
				Ground.Instance, Steel.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Excadrill Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public Excadrill() : base(
			530,
			SpeciesExcadrill.Instance, // PokemonInstance Species
			Ground.Instance, Steel.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}