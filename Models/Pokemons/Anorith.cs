using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Anorith Species to store common natural stats of all Anoriths
	#region SpeciesAnorith
	public class SpeciesAnorith : PokemonSpecies
	{
#nullable enable
		private static SpeciesAnorith? _instance = null;
#nullable restore
        public static SpeciesAnorith Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesAnorith();
                }
                return _instance;
            }
        }

		#region SpeciesAnorith Constructor
		public SpeciesAnorith() : base(
			347,
			"Anorith",
			0.7,
			12.5,
			45, // HPs
			95, 50, // Attack & Defense
			40, 50, // Special Attack & Defense
			75		
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
				"Sand-Attack",
				"Headbutt",
				"Body-Slam",
				"Double-Edge",
				"Water-Gun",
				"String-Shot",
				"Dig",
				"Toxic",
				"Mimic",
				"Screech",
				"Double-Team",
				"Harden",
				"Rest",
				"Rock-Slide",
				"Slash",
				"Substitute",
				"Snore",
				"Curse",
				"Protect",
				"Mud-Slap",
				"Sandstorm",
				"Endure",
				"False-Swipe",
				"Swagger",
				"Fury-Cutter",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Rapid-Spin",
				"Metal-Claw",
				"Hidden-Power",
				"Sunny-Day",
				"Ancient-Power",
				"Rock-Smash",
				"Facade",
				"Brick-Break",
				"Knock-Off",
				"Secret-Power",
				"Mud-Sport",
				"Crush-Claw",
				"Rock-Tomb",
				"Aerial-Ace",
				"Iron-Defense",
				"Rock-Blast",
				"Water-Pulse",
				"Brine",
				"Natural-Gift",
				"Rock-Polish",
				"X-Scissor",
				"Earth-Power",
				"Cross-Poison",
				"Captivate",
				"Stealth-Rock",
				"Bug-Bite",
				"Aqua-Jet",
				"Hone-Claws",
				"Smack-Down",
				"Round",
				"Struggle-Bug",
				"Confide"
			};
		}
		#endregion
	}
	#endregion

	//Anorith PokemonInstance Class
	#region Anorith
	public class AnorithInstance : PokemonInstance
	{
		#region Anorith Constructors
		/// <summary>
		/// Anorith Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public AnorithInstance(string nickname, int level)
		: base(
				SpeciesAnorith.Instance, // Pokemon Species
				nickname, level,
				Rock.Instance, Bug.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Anorith Builder only waiting for a Level
		/// </summary>
		public AnorithInstance(int level)
		: base(
				SpeciesAnorith.Instance, // PokemonInstance Species
				"Anorith", level,
				Rock.Instance, Bug.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Anorith Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public AnorithInstance() : base(
			SpeciesAnorith.Instance, // PokemonInstance Species
			Rock.Instance, Bug.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}