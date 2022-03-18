using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Gligar Species to store common natural stats of all Gligars
	#region SpeciesGligar
	public class SpeciesGligar : PokemonSpecies
	{
#nullable enable
		private static SpeciesGligar? _instance = null;
#nullable restore
        public static SpeciesGligar Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesGligar();
                }
                return _instance;
            }
        }

		#region SpeciesGligar Constructor
		public SpeciesGligar() : base(
			207,
			"Gligar",
			1.1,
			64.8,
			65, // HPs
			75, 105, // Attack & Defense
			35, 65, // Special Attack & Defense
			85		
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
				"Razor-Wind",
				"Swords-Dance",
				"Cut",
				"Wing-Attack",
				"Sand-Attack",
				"Headbutt",
				"Double-Edge",
				"Poison-Sting",
				"Counter",
				"Strength",
				"Earthquake",
				"Dig",
				"Toxic",
				"Agility",
				"Quick-Attack",
				"Mimic",
				"Screech",
				"Double-Team",
				"Harden",
				"Swift",
				"Dream-Eater",
				"Rest",
				"Rock-Slide",
				"Slash",
				"Substitute",
				"Thief",
				"Snore",
				"Curse",
				"Protect",
				"Feint-Attack",
				"Sludge-Bomb",
				"Detect",
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
				"Baton-Pass",
				"Iron-Tail",
				"Metal-Claw",
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
				"Sand-Tomb",
				"Aerial-Ace",
				"Poison-Tail",
				"Roost",
				"Natural-Gift",
				"Feint",
				"Tailwind",
				"U-Turn",
				"Payback",
				"Fling",
				"Power-Trick",
				"Rock-Polish",
				"Poison-Jab",
				"Dark-Pulse",
				"Night-Slash",
				"Aqua-Tail",
				"X-Scissor",
				"Earth-Power",
				"Rock-Climb",
				"Defog",
				"Cross-Poison",
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
				"Confide"
			};
		}
		#endregion
	}
	#endregion

	//Gligar PokemonInstance Class
	#region Gligar
	public class GligarInstance : PokemonInstance
	{
		#region Gligar Constructors
		/// <summary>
		/// Gligar Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public GligarInstance(string nickname, int level)
		: base(
				SpeciesGligar.Instance, // Pokemon Species
				nickname, level,
				Ground.Instance, Flying.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Gligar Builder only waiting for a Level
		/// </summary>
		public GligarInstance(int level)
		: base(
				SpeciesGligar.Instance, // PokemonInstance Species
				"Gligar", level,
				Ground.Instance, Flying.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Gligar Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public GligarInstance() : base(
			SpeciesGligar.Instance, // PokemonInstance Species
			Ground.Instance, Flying.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}