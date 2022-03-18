using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Shedinja Species to store common natural stats of all Shedinjas
	#region SpeciesShedinja
	public class SpeciesShedinja : PokemonSpecies
	{
#nullable enable
		private static SpeciesShedinja? _instance = null;
#nullable restore
        public static SpeciesShedinja Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesShedinja();
                }
                return _instance;
            }
        }

		#region SpeciesShedinja Constructor
		public SpeciesShedinja() : base(
			292,
			"Shedinja",
			0.8,
			1.2,
			1, // HPs
			90, 45, // Attack & Defense
			30, 30, // Special Attack & Defense
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
				"Scratch",
				"Cut",
				"Sand-Attack",
				"Double-Edge",
				"Hyper-Beam",
				"Absorb",
				"Solar-Beam",
				"String-Shot",
				"Dig",
				"Toxic",
				"Mimic",
				"Double-Team",
				"Harden",
				"Confuse-Ray",
				"Dream-Eater",
				"Leech-Life",
				"Flash",
				"Fury-Swipes",
				"Rest",
				"Substitute",
				"Thief",
				"Mind-Reader",
				"Nightmare",
				"Snore",
				"Spite",
				"Protect",
				"Mud-Slap",
				"Sandstorm",
				"Giga-Drain",
				"Endure",
				"False-Swipe",
				"Swagger",
				"Fury-Cutter",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Hidden-Power",
				"Sunny-Day",
				"Shadow-Ball",
				"Will-O-Wisp",
				"Facade",
				"Trick",
				"Grudge",
				"Secret-Power",
				"Aerial-Ace",
				"Natural-Gift",
				"Heal-Block",
				"Sucker-Punch",
				"X-Scissor",
				"Giga-Impact",
				"Shadow-Claw",
				"Shadow-Sneak",
				"Bug-Bite",
				"Hone-Claws",
				"Telekinesis",
				"Round",
				"Struggle-Bug",
				"Phantom-Force",
				"Confide"
			};
		}
		#endregion
	}
	#endregion

	//Shedinja PokemonInstance Class
	#region Shedinja
	public class ShedinjaInstance : PokemonInstance
	{
		#region Shedinja Constructors
		/// <summary>
		/// Shedinja Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public ShedinjaInstance(string nickname, int level)
		: base(
				SpeciesShedinja.Instance, // Pokemon Species
				nickname, level,
				Bug.Instance, Ghost.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Shedinja Builder only waiting for a Level
		/// </summary>
		public ShedinjaInstance(int level)
		: base(
				SpeciesShedinja.Instance, // PokemonInstance Species
				"Shedinja", level,
				Bug.Instance, Ghost.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Shedinja Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public ShedinjaInstance() : base(
			SpeciesShedinja.Instance, // PokemonInstance Species
			Bug.Instance, Ghost.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}