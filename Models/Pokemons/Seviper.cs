using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Seviper Species to store common natural stats of all Sevipers
	#region SpeciesSeviper
	public class SpeciesSeviper : PokemonSpecies
	{
#nullable enable
		private static SpeciesSeviper? _instance = null;
#nullable restore
        public static SpeciesSeviper Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesSeviper();
                }
                return _instance;
            }
        }

		#region SpeciesSeviper Constructor
		public SpeciesSeviper() : base(
			336,
			"Seviper",
			2.7,
			52.5,
			73, // HPs
			100, 60, // Attack & Defense
			100, 60, // Special Attack & Defense
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
				"Bind",
				"Headbutt",
				"Body-Slam",
				"Wrap",
				"Double-Edge",
				"Bite",
				"Flamethrower",
				"Strength",
				"Earthquake",
				"Dig",
				"Toxic",
				"Mimic",
				"Screech",
				"Double-Team",
				"Haze",
				"Lick",
				"Swift",
				"Glare",
				"Rest",
				"Substitute",
				"Thief",
				"Snore",
				"Protect",
				"Scary-Face",
				"Sludge-Bomb",
				"Mud-Slap",
				"Giga-Drain",
				"Endure",
				"Swagger",
				"Fury-Cutter",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Iron-Tail",
				"Hidden-Power",
				"Rain-Dance",
				"Sunny-Day",
				"Crunch",
				"Rock-Smash",
				"Stockpile",
				"Spit-Up",
				"Swallow",
				"Facade",
				"Taunt",
				"Knock-Off",
				"Snatch",
				"Secret-Power",
				"Poison-Fang",
				"Poison-Tail",
				"Natural-Gift",
				"Feint",
				"Payback",
				"Assurance",
				"Wring-Out",
				"Gastro-Acid",
				"Punishment",
				"Sucker-Punch",
				"Poison-Jab",
				"Dark-Pulse",
				"Night-Slash",
				"Aqua-Tail",
				"X-Scissor",
				"Switcheroo",
				"Captivate",
				"Venoshock",
				"Sludge-Wave",
				"Coil",
				"Round",
				"Retaliate",
				"Final-Gambit",
				"Bulldoze",
				"Dragon-Tail",
				"Belch",
				"Confide",
				"Venom-Drench",
				"Infestation",
				"Brutal-Swing"
			};
		}
		#endregion
	}
	#endregion

	//Seviper PokemonInstance Class
	#region Seviper
	public class SeviperInstance : PokemonInstance
	{
		#region Seviper Constructors
		/// <summary>
		/// Seviper Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public SeviperInstance(string nickname, int level)
		: base(
				SpeciesSeviper.Instance, // Pokemon Species
				nickname, level,
				Poison.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Seviper Builder only waiting for a Level
		/// </summary>
		public SeviperInstance(int level)
		: base(
				SpeciesSeviper.Instance, // PokemonInstance Species
				"Seviper", level,
				Poison.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Seviper Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public SeviperInstance() : base(
			SpeciesSeviper.Instance, // PokemonInstance Species
			Poison.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}