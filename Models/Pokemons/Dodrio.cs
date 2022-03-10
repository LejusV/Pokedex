using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Dodrio Species to store common natural stats of all Dodrios
	#region SpeciesDodrio
	public class SpeciesDodrio : PokemonSpecies
	{
#nullable enable
		private static SpeciesDodrio? _instance = null;
#nullable restore
        public static SpeciesDodrio Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesDodrio();
                }
                return _instance;
            }
        }

		#region SpeciesDodrio Constructor
		public SpeciesDodrio() : base(
			"Dodrio",
			1.8,
			85.2,
			60, // HPs
			110, 70, // Attack & Defense
			60, 60, // Special Attack & Defense
			110		
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
				"Whirlwind",
				"Fly",
				"Jump-Kick",
				"Fury-Attack",
				"Body-Slam",
				"Take-Down",
				"Thrash",
				"Double-Edge",
				"Growl",
				"Hyper-Beam",
				"Peck",
				"Drill-Peck",
				"Toxic",
				"Agility",
				"Quick-Attack",
				"Rage",
				"Mimic",
				"Double-Team",
				"Reflect",
				"Bide",
				"Swift",
				"Skull-Bash",
				"Sky-Attack",
				"Rest",
				"Tri-Attack",
				"Substitute",
				"Thief",
				"Snore",
				"Curse",
				"Protect",
				"Mud-Slap",
				"Endure",
				"Swagger",
				"Steel-Wing",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Pursuit",
				"Hidden-Power",
				"Sunny-Day",
				"Uproar",
				"Torment",
				"Facade",
				"Taunt",
				"Knock-Off",
				"Endeavor",
				"Secret-Power",
				"Air-Cutter",
				"Aerial-Ace",
				"Roost",
				"Natural-Gift",
				"Pluck",
				"Acupressure",
				"Payback",
				"Giga-Impact",
				"Captivate",
				"Double-Hit",
				"Round",
				"Echoed-Voice",
				"Work-Up",
				"Confide"
			};
		}
		#endregion
	}
	#endregion

	//Dodrio PokemonInstance Class
	#region Dodrio
	public class DodrioInstance : PokemonInstance
	{
		#region Dodrio Constructors
		/// <summary>
		/// Dodrio Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public DodrioInstance(string nickname, int level)
		: base(
				85,
				SpeciesDodrio.Instance, // Pokemon Species
				nickname, level,
				Normal.Instance, Flying.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Dodrio Builder only waiting for a Level
		/// </summary>
		public DodrioInstance(int level)
		: base(
				85,
				SpeciesDodrio.Instance, // PokemonInstance Species
				"Dodrio", level,
				Normal.Instance, Flying.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Dodrio Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public Dodrio() : base(
			85,
			SpeciesDodrio.Instance, // PokemonInstance Species
			Normal.Instance, Flying.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}