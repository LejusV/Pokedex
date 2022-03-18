using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Drapion Species to store common natural stats of all Drapions
	#region SpeciesDrapion
	public class SpeciesDrapion : PokemonSpecies
	{
#nullable enable
		private static SpeciesDrapion? _instance = null;
#nullable restore
        public static SpeciesDrapion Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesDrapion();
                }
                return _instance;
            }
        }

		#region SpeciesDrapion Constructor
		public SpeciesDrapion() : base(
			452,
			"Drapion",
			1.3,
			61.5,
			70, // HPs
			90, 110, // Attack & Defense
			60, 75, // Special Attack & Defense
			95		
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
				"Headbutt",
				"Poison-Sting",
				"Pin-Missile",
				"Leer",
				"Bite",
				"Roar",
				"Hyper-Beam",
				"Strength",
				"Earthquake",
				"Dig",
				"Toxic",
				"Double-Team",
				"Flash",
				"Rest",
				"Rock-Slide",
				"Substitute",
				"Thief",
				"Snore",
				"Protect",
				"Scary-Face",
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
				"Giga-Impact",
				"Thunder-Fang",
				"Ice-Fang",
				"Fire-Fang",
				"Rock-Climb",
				"Cross-Poison",
				"Captivate",
				"Bug-Bite",
				"Hone-Claws",
				"Venoshock",
				"Round",
				"Retaliate",
				"Struggle-Bug",
				"Bulldoze",
				"Snarl",
				"Fell-Stinger",
				"Confide",
				"Infestation",
				"Brutal-Swing"
			};
		}
		#endregion
	}
	#endregion

	//Drapion PokemonInstance Class
	#region Drapion
	public class DrapionInstance : PokemonInstance
	{
		#region Drapion Constructors
		/// <summary>
		/// Drapion Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public DrapionInstance(string nickname, int level)
		: base(
				SpeciesDrapion.Instance, // Pokemon Species
				nickname, level,
				Poison.Instance, Dark.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Drapion Builder only waiting for a Level
		/// </summary>
		public DrapionInstance(int level)
		: base(
				SpeciesDrapion.Instance, // PokemonInstance Species
				"Drapion", level,
				Poison.Instance, Dark.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Drapion Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public DrapionInstance() : base(
			SpeciesDrapion.Instance, // PokemonInstance Species
			Poison.Instance, Dark.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}