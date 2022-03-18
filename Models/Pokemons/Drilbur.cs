using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Drilbur Species to store common natural stats of all Drilburs
	#region SpeciesDrilbur
	public class SpeciesDrilbur : PokemonSpecies
	{
#nullable enable
		private static SpeciesDrilbur? _instance = null;
#nullable restore
        public static SpeciesDrilbur Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesDrilbur();
                }
                return _instance;
            }
        }

		#region SpeciesDrilbur Constructor
		public SpeciesDrilbur() : base(
			529,
			"Drilbur",
			0.3,
			8.5,
			60, // HPs
			85, 40, // Attack & Defense
			30, 45, // Special Attack & Defense
			68		
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
				"Submission",
				"Strength",
				"Earthquake",
				"Fissure",
				"Dig",
				"Toxic",
				"Double-Team",
				"Skull-Bash",
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
				"Crush-Claw",
				"Rock-Tomb",
				"Metal-Sound",
				"Aerial-Ace",
				"Iron-Defense",
				"Fling",
				"Poison-Jab",
				"X-Scissor",
				"Earth-Power",
				"Shadow-Claw",
				"Rock-Climb",
				"Stealth-Rock",
				"Hone-Claws",
				"Round",
				"Bulldoze",
				"Drill-Run",
				"Confide"
			};
		}
		#endregion
	}
	#endregion

	//Drilbur PokemonInstance Class
	#region Drilbur
	public class DrilburInstance : PokemonInstance
	{
		#region Drilbur Constructors
		/// <summary>
		/// Drilbur Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public DrilburInstance(string nickname, int level)
		: base(
				SpeciesDrilbur.Instance, // Pokemon Species
				nickname, level,
				Ground.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Drilbur Builder only waiting for a Level
		/// </summary>
		public DrilburInstance(int level)
		: base(
				SpeciesDrilbur.Instance, // PokemonInstance Species
				"Drilbur", level,
				Ground.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Drilbur Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public DrilburInstance() : base(
			SpeciesDrilbur.Instance, // PokemonInstance Species
			Ground.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}