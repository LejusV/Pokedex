using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Beedrill Species to store common natural stats of all Beedrills
	#region SpeciesBeedrill
	public class SpeciesBeedrill : PokemonSpecies
	{
#nullable enable
		private static SpeciesBeedrill? _instance = null;
#nullable restore
        public static SpeciesBeedrill Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesBeedrill();
                }
                return _instance;
            }
        }

		#region SpeciesBeedrill Constructor
		public SpeciesBeedrill() : base(
			15,
			"Beedrill",
			1.0,
			29.5,
			65, // HPs
			90, 40, // Attack & Defense
			45, 80, // Special Attack & Defense
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
				"Swords-Dance",
				"Cut",
				"Fury-Attack",
				"Take-Down",
				"Double-Edge",
				"Twineedle",
				"Pin-Missile",
				"Hyper-Beam",
				"Mega-Drain",
				"Solar-Beam",
				"String-Shot",
				"Toxic",
				"Agility",
				"Rage",
				"Mimic",
				"Double-Team",
				"Reflect",
				"Focus-Energy",
				"Bide",
				"Swift",
				"Skull-Bash",
				"Flash",
				"Rest",
				"Substitute",
				"Thief",
				"Snore",
				"Curse",
				"Protect",
				"Sludge-Bomb",
				"Giga-Drain",
				"Endure",
				"False-Swipe",
				"Swagger",
				"Fury-Cutter",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Pursuit",
				"Sweet-Scent",
				"Hidden-Power",
				"Sunny-Day",
				"Rock-Smash",
				"Facade",
				"Brick-Break",
				"Knock-Off",
				"Endeavor",
				"Secret-Power",
				"Air-Cutter",
				"Silver-Wind",
				"Aerial-Ace",
				"Roost",
				"Natural-Gift",
				"Tailwind",
				"U-Turn",
				"Payback",
				"Assurance",
				"Toxic-Spikes",
				"Poison-Jab",
				"X-Scissor",
				"Giga-Impact",
				"Defog",
				"Captivate",
				"Bug-Bite",
				"Ominous-Wind",
				"Venoshock",
				"Round",
				"Acrobatics",
				"Struggle-Bug",
				"Electroweb",
				"Drill-Run",
				"Fell-Stinger",
				"Confide",
				"Infestation",
				"Brutal-Swing"
			};
		}
		#endregion
	}
	#endregion

	//Beedrill PokemonInstance Class
	#region Beedrill
	public class BeedrillInstance : PokemonInstance
	{
		#region Beedrill Constructors
		/// <summary>
		/// Beedrill Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public BeedrillInstance(string nickname, int level)
		: base(
				SpeciesBeedrill.Instance, // Pokemon Species
				nickname, level,
				Bug.Instance, Poison.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Beedrill Builder only waiting for a Level
		/// </summary>
		public BeedrillInstance(int level)
		: base(
				SpeciesBeedrill.Instance, // PokemonInstance Species
				"Beedrill", level,
				Bug.Instance, Poison.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Beedrill Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public BeedrillInstance() : base(
			SpeciesBeedrill.Instance, // PokemonInstance Species
			Bug.Instance, Poison.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}