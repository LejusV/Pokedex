using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Skorupi Species to store common natural stats of all Skorupis
	#region SpeciesSkorupi
	public class SpeciesSkorupi : PokemonSpecies
	{
#nullable enable
		private static SpeciesSkorupi? _instance = null;
#nullable restore
        public static SpeciesSkorupi Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesSkorupi();
                }
                return _instance;
            }
        }

		#region SpeciesSkorupi Constructor
		public SpeciesSkorupi() : base(
			"Skorupi",
			0.8,
			12.0,
			40, // HPs
			50, 90, // Attack & Defense
			30, 55, // Special Attack & Defense
			65		
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
				"Whirlwind",
				"Sand-Attack",
				"Headbutt",
				"Poison-Sting",
				"Twineedle",
				"Pin-Missile",
				"Leer",
				"Bite",
				"Strength",
				"Dig",
				"Toxic",
				"Agility",
				"Screech",
				"Double-Team",
				"Confuse-Ray",
				"Flash",
				"Rest",
				"Slash",
				"Substitute",
				"Thief",
				"Snore",
				"Protect",
				"Scary-Face",
				"Feint-Attack",
				"Sludge-Bomb",
				"Mud-Slap",
				"Endure",
				"False-Swipe",
				"Swagger",
				"Fury-Cutter",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Pursuit",
				"Iron-Tail",
				"Hidden-Power",
				"Rain-Dance",
				"Sunny-Day",
				"Crunch",
				"Shadow-Ball",
				"Rock-Smash",
				"Torment",
				"Facade",
				"Taunt",
				"Brick-Break",
				"Knock-Off",
				"Secret-Power",
				"Poison-Fang",
				"Rock-Tomb",
				"Aerial-Ace",
				"Poison-Tail",
				"Natural-Gift",
				"Acupressure",
				"Payback",
				"Fling",
				"Toxic-Spikes",
				"Poison-Jab",
				"Dark-Pulse",
				"Night-Slash",
				"Aqua-Tail",
				"X-Scissor",
				"Cross-Poison",
				"Captivate",
				"Bug-Bite",
				"Hone-Claws",
				"Venoshock",
				"Round",
				"Struggle-Bug",
				"Fell-Stinger",
				"Confide",
				"Infestation"
			};
		}
		#endregion
	}
	#endregion

	//Skorupi PokemonInstance Class
	#region Skorupi
	public class SkorupiInstance : PokemonInstance
	{
		#region Skorupi Constructors
		/// <summary>
		/// Skorupi Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public SkorupiInstance(string nickname, int level)
		: base(
				451,
				SpeciesSkorupi.Instance, // Pokemon Species
				nickname, level,
				Poison.Instance, Bug.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Skorupi Builder only waiting for a Level
		/// </summary>
		public SkorupiInstance(int level)
		: base(
				451,
				SpeciesSkorupi.Instance, // PokemonInstance Species
				"Skorupi", level,
				Poison.Instance, Bug.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Skorupi Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public Skorupi() : base(
			451,
			SpeciesSkorupi.Instance, // PokemonInstance Species
			Poison.Instance, Bug.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}