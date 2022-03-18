using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Gliscor Species to store common natural stats of all Gliscors
	#region SpeciesGliscor
	public class SpeciesGliscor : PokemonSpecies
	{
#nullable enable
		private static SpeciesGliscor? _instance = null;
#nullable restore
        public static SpeciesGliscor Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesGliscor();
                }
                return _instance;
            }
        }

		#region SpeciesGliscor Constructor
		public SpeciesGliscor() : base(
			472,
			"Gliscor",
			2.0,
			42.5,
			75, // HPs
			95, 125, // Attack & Defense
			45, 75, // Special Attack & Defense
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
				"Guillotine",
				"Swords-Dance",
				"Cut",
				"Sand-Attack",
				"Headbutt",
				"Hyper-Beam",
				"Strength",
				"Earthquake",
				"Dig",
				"Toxic",
				"Quick-Attack",
				"Screech",
				"Double-Team",
				"Harden",
				"Swift",
				"Sky-Attack",
				"Rest",
				"Rock-Slide",
				"Substitute",
				"Thief",
				"Snore",
				"Protect",
				"Feint-Attack",
				"Sludge-Bomb",
				"Mud-Slap",
				"Sandstorm",
				"Endure",
				"False-Swipe",
				"Swagger",
				"Fury-Cutter",
				"Steel-Wing",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Iron-Tail",
				"Hidden-Power",
				"Rain-Dance",
				"Sunny-Day",
				"Rock-Smash",
				"Torment",
				"Facade",
				"Taunt",
				"Brick-Break",
				"Knock-Off",
				"Secret-Power",
				"Rock-Tomb",
				"Sky-Uppercut",
				"Aerial-Ace",
				"Roost",
				"Natural-Gift",
				"Tailwind",
				"U-Turn",
				"Payback",
				"Fling",
				"Rock-Polish",
				"Poison-Jab",
				"Dark-Pulse",
				"Night-Slash",
				"Aqua-Tail",
				"X-Scissor",
				"Earth-Power",
				"Giga-Impact",
				"Thunder-Fang",
				"Ice-Fang",
				"Fire-Fang",
				"Defog",
				"Stone-Edge",
				"Captivate",
				"Stealth-Rock",
				"Bug-Bite",
				"Hone-Claws",
				"Venoshock",
				"Round",
				"Acrobatics",
				"Struggle-Bug",
				"Bulldoze",
				"Confide",
				"Brutal-Swing"
			};
		}
		#endregion
	}
	#endregion

	//Gliscor PokemonInstance Class
	#region Gliscor
	public class GliscorInstance : PokemonInstance
	{
		#region Gliscor Constructors
		/// <summary>
		/// Gliscor Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public GliscorInstance(string nickname, int level)
		: base(
				SpeciesGliscor.Instance, // Pokemon Species
				nickname, level,
				Ground.Instance, Flying.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Gliscor Builder only waiting for a Level
		/// </summary>
		public GliscorInstance(int level)
		: base(
				SpeciesGliscor.Instance, // PokemonInstance Species
				"Gliscor", level,
				Ground.Instance, Flying.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Gliscor Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public GliscorInstance() : base(
			SpeciesGliscor.Instance, // PokemonInstance Species
			Ground.Instance, Flying.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}