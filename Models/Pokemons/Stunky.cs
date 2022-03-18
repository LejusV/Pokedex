using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Stunky Species to store common natural stats of all Stunkys
	#region SpeciesStunky
	public class SpeciesStunky : PokemonSpecies
	{
#nullable enable
		private static SpeciesStunky? _instance = null;
#nullable restore
        public static SpeciesStunky Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesStunky();
                }
                return _instance;
            }
        }

		#region SpeciesStunky Constructor
		public SpeciesStunky() : base(
			434,
			"Stunky",
			0.4,
			19.2,
			63, // HPs
			63, 47, // Attack & Defense
			41, 41, // Special Attack & Defense
			74		
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
				"Headbutt",
				"Double-Edge",
				"Leer",
				"Bite",
				"Roar",
				"Flamethrower",
				"Dig",
				"Toxic",
				"Screech",
				"Double-Team",
				"Smokescreen",
				"Haze",
				"Focus-Energy",
				"Smog",
				"Fire-Blast",
				"Swift",
				"Poison-Gas",
				"Explosion",
				"Fury-Swipes",
				"Rest",
				"Slash",
				"Substitute",
				"Thief",
				"Snore",
				"Protect",
				"Scary-Face",
				"Sludge-Bomb",
				"Mud-Slap",
				"Endure",
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
				"Memento",
				"Facade",
				"Taunt",
				"Snatch",
				"Secret-Power",
				"Astonish",
				"Natural-Gift",
				"Feint",
				"Payback",
				"Punishment",
				"Sucker-Punch",
				"Dark-Pulse",
				"Night-Slash",
				"Shadow-Claw",
				"Defog",
				"Captivate",
				"Hone-Claws",
				"Venoshock",
				"Flame-Burst",
				"Acid-Spray",
				"Foul-Play",
				"Round",
				"Incinerate",
				"Snarl",
				"Belch",
				"Play-Rough",
				"Confide",
				"Venom-Drench"
			};
		}
		#endregion
	}
	#endregion

	//Stunky PokemonInstance Class
	#region Stunky
	public class StunkyInstance : PokemonInstance
	{
		#region Stunky Constructors
		/// <summary>
		/// Stunky Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public StunkyInstance(string nickname, int level)
		: base(
				SpeciesStunky.Instance, // Pokemon Species
				nickname, level,
				Poison.Instance, Dark.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Stunky Builder only waiting for a Level
		/// </summary>
		public StunkyInstance(int level)
		: base(
				SpeciesStunky.Instance, // PokemonInstance Species
				"Stunky", level,
				Poison.Instance, Dark.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Stunky Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public StunkyInstance() : base(
			SpeciesStunky.Instance, // PokemonInstance Species
			Poison.Instance, Dark.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}