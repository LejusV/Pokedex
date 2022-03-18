using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Skarmory Species to store common natural stats of all Skarmorys
	#region SpeciesSkarmory
	public class SpeciesSkarmory : PokemonSpecies
	{
#nullable enable
		private static SpeciesSkarmory? _instance = null;
#nullable restore
        public static SpeciesSkarmory Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesSkarmory();
                }
                return _instance;
            }
        }

		#region SpeciesSkarmory Constructor
		public SpeciesSkarmory() : base(
			227,
			"Skarmory",
			1.7,
			50.5,
			65, // HPs
			80, 140, // Attack & Defense
			40, 70, // Special Attack & Defense
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
				"Swords-Dance",
				"Cut",
				"Whirlwind",
				"Fly",
				"Sand-Attack",
				"Fury-Attack",
				"Double-Edge",
				"Leer",
				"Roar",
				"Peck",
				"Drill-Peck",
				"Counter",
				"Toxic",
				"Agility",
				"Mimic",
				"Double-Team",
				"Swift",
				"Sky-Attack",
				"Flash",
				"Rest",
				"Rock-Slide",
				"Slash",
				"Substitute",
				"Thief",
				"Snore",
				"Curse",
				"Protect",
				"Mud-Slap",
				"Spikes",
				"Icy-Wind",
				"Detect",
				"Sandstorm",
				"Endure",
				"Swagger",
				"Fury-Cutter",
				"Steel-Wing",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Pursuit",
				"Metal-Claw",
				"Hidden-Power",
				"Twister",
				"Sunny-Day",
				"Rock-Smash",
				"Torment",
				"Facade",
				"Taunt",
				"Secret-Power",
				"Air-Cutter",
				"Rock-Tomb",
				"Metal-Sound",
				"Aerial-Ace",
				"Iron-Defense",
				"Roost",
				"Natural-Gift",
				"Feint",
				"Pluck",
				"Tailwind",
				"Payback",
				"Assurance",
				"Guard-Swap",
				"Dark-Pulse",
				"Night-Slash",
				"Air-Slash",
				"X-Scissor",
				"Brave-Bird",
				"Flash-Cannon",
				"Defog",
				"Iron-Head",
				"Captivate",
				"Stealth-Rock",
				"Ominous-Wind",
				"Autotomize",
				"Round",
				"Sky-Drop",
				"Confide"
			};
		}
		#endregion
	}
	#endregion

	//Skarmory PokemonInstance Class
	#region Skarmory
	public class SkarmoryInstance : PokemonInstance
	{
		#region Skarmory Constructors
		/// <summary>
		/// Skarmory Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public SkarmoryInstance(string nickname, int level)
		: base(
				SpeciesSkarmory.Instance, // Pokemon Species
				nickname, level,
				Steel.Instance, Flying.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Skarmory Builder only waiting for a Level
		/// </summary>
		public SkarmoryInstance(int level)
		: base(
				SpeciesSkarmory.Instance, // PokemonInstance Species
				"Skarmory", level,
				Steel.Instance, Flying.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Skarmory Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public SkarmoryInstance() : base(
			SpeciesSkarmory.Instance, // PokemonInstance Species
			Steel.Instance, Flying.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}