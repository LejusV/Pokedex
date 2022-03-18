using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Butterfree Species to store common natural stats of all Butterfrees
	#region SpeciesButterfree
	public class SpeciesButterfree : PokemonSpecies
	{
#nullable enable
		private static SpeciesButterfree? _instance = null;
#nullable restore
        public static SpeciesButterfree Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesButterfree();
                }
                return _instance;
            }
        }

		#region SpeciesButterfree Constructor
		public SpeciesButterfree() : base(
			12,
			"Butterfree",
			1.1,
			32.0,
			60, // HPs
			45, 50, // Attack & Defense
			90, 80, // Special Attack & Defense
			70		
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
				"Razor-Wind",
				"Gust",
				"Whirlwind",
				"Take-Down",
				"Double-Edge",
				"Supersonic",
				"Psybeam",
				"Hyper-Beam",
				"Mega-Drain",
				"Solar-Beam",
				"Poison-Powder",
				"Stun-Spore",
				"Sleep-Powder",
				"String-Shot",
				"Toxic",
				"Confusion",
				"Psychic",
				"Rage",
				"Teleport",
				"Mimic",
				"Double-Team",
				"Reflect",
				"Bide",
				"Swift",
				"Dream-Eater",
				"Flash",
				"Psywave",
				"Rest",
				"Substitute",
				"Thief",
				"Nightmare",
				"Snore",
				"Curse",
				"Protect",
				"Giga-Drain",
				"Endure",
				"Swagger",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Safeguard",
				"Sweet-Scent",
				"Hidden-Power",
				"Twister",
				"Rain-Dance",
				"Sunny-Day",
				"Psych-Up",
				"Shadow-Ball",
				"Facade",
				"Skill-Swap",
				"Secret-Power",
				"Air-Cutter",
				"Silver-Wind",
				"Signal-Beam",
				"Aerial-Ace",
				"Roost",
				"Natural-Gift",
				"Tailwind",
				"U-Turn",
				"Air-Slash",
				"Bug-Buzz",
				"Energy-Ball",
				"Giga-Impact",
				"Defog",
				"Captivate",
				"Bug-Bite",
				"Ominous-Wind",
				"Venoshock",
				"Rage-Powder",
				"Quiver-Dance",
				"Round",
				"Acrobatics",
				"Struggle-Bug",
				"Electroweb",
				"Confide",
				"Infestation"
			};
		}
		#endregion
	}
	#endregion

	//Butterfree PokemonInstance Class
	#region Butterfree
	public class ButterfreeInstance : PokemonInstance
	{
		#region Butterfree Constructors
		/// <summary>
		/// Butterfree Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public ButterfreeInstance(string nickname, int level)
		: base(
				SpeciesButterfree.Instance, // Pokemon Species
				nickname, level,
				Bug.Instance, Flying.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Butterfree Builder only waiting for a Level
		/// </summary>
		public ButterfreeInstance(int level)
		: base(
				SpeciesButterfree.Instance, // PokemonInstance Species
				"Butterfree", level,
				Bug.Instance, Flying.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Butterfree Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public ButterfreeInstance() : base(
			SpeciesButterfree.Instance, // PokemonInstance Species
			Bug.Instance, Flying.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}