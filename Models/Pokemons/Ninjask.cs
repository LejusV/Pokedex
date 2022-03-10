using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Ninjask Species to store common natural stats of all Ninjasks
	#region SpeciesNinjask
	public class SpeciesNinjask : PokemonSpecies
	{
#nullable enable
		private static SpeciesNinjask? _instance = null;
#nullable restore
        public static SpeciesNinjask Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesNinjask();
                }
                return _instance;
            }
        }

		#region SpeciesNinjask Constructor
		public SpeciesNinjask() : base(
			"Ninjask",
			0.8,
			12.0,
			61, // HPs
			90, 45, // Attack & Defense
			50, 50, // Special Attack & Defense
			160		
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
				"Double-Edge",
				"Hyper-Beam",
				"Absorb",
				"Solar-Beam",
				"String-Shot",
				"Dig",
				"Toxic",
				"Agility",
				"Mimic",
				"Screech",
				"Double-Team",
				"Harden",
				"Swift",
				"Leech-Life",
				"Flash",
				"Fury-Swipes",
				"Rest",
				"Slash",
				"Substitute",
				"Thief",
				"Mind-Reader",
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
				"Attract",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Baton-Pass",
				"Hidden-Power",
				"Sunny-Day",
				"Shadow-Ball",
				"Uproar",
				"Facade",
				"Secret-Power",
				"Air-Cutter",
				"Silver-Wind",
				"Aerial-Ace",
				"Roost",
				"Natural-Gift",
				"U-Turn",
				"X-Scissor",
				"Giga-Impact",
				"Defog",
				"Captivate",
				"Bug-Bite",
				"Ominous-Wind",
				"Hone-Claws",
				"Round",
				"Struggle-Bug",
				"Confide"
			};
		}
		#endregion
	}
	#endregion

	//Ninjask PokemonInstance Class
	#region Ninjask
	public class NinjaskInstance : PokemonInstance
	{
		#region Ninjask Constructors
		/// <summary>
		/// Ninjask Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public NinjaskInstance(string nickname, int level)
		: base(
				291,
				SpeciesNinjask.Instance, // Pokemon Species
				nickname, level,
				Bug.Instance, Flying.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Ninjask Builder only waiting for a Level
		/// </summary>
		public NinjaskInstance(int level)
		: base(
				291,
				SpeciesNinjask.Instance, // PokemonInstance Species
				"Ninjask", level,
				Bug.Instance, Flying.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Ninjask Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public Ninjask() : base(
			291,
			SpeciesNinjask.Instance, // PokemonInstance Species
			Bug.Instance, Flying.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}