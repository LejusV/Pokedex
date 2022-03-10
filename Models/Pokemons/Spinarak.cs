using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Spinarak Species to store common natural stats of all Spinaraks
	#region SpeciesSpinarak
	public class SpeciesSpinarak : PokemonSpecies
	{
#nullable enable
		private static SpeciesSpinarak? _instance = null;
#nullable restore
        public static SpeciesSpinarak Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesSpinarak();
                }
                return _instance;
            }
        }

		#region SpeciesSpinarak Constructor
		public SpeciesSpinarak() : base(
			"Spinarak",
			0.5,
			8.5,
			40, // HPs
			60, 40, // Attack & Defense
			40, 40, // Special Attack & Defense
			30		
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
				"Body-Slam",
				"Double-Edge",
				"Poison-Sting",
				"Twineedle",
				"Pin-Missile",
				"Sonic-Boom",
				"Disable",
				"Psybeam",
				"Absorb",
				"Solar-Beam",
				"String-Shot",
				"Dig",
				"Toxic",
				"Psychic",
				"Agility",
				"Night-Shade",
				"Mimic",
				"Screech",
				"Double-Team",
				"Constrict",
				"Leech-Life",
				"Flash",
				"Fury-Swipes",
				"Rest",
				"Substitute",
				"Thief",
				"Spider-Web",
				"Snore",
				"Curse",
				"Protect",
				"Scary-Face",
				"Sludge-Bomb",
				"Giga-Drain",
				"Endure",
				"Swagger",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Megahorn",
				"Baton-Pass",
				"Pursuit",
				"Hidden-Power",
				"Sunny-Day",
				"Facade",
				"Secret-Power",
				"Signal-Beam",
				"Bounce",
				"Natural-Gift",
				"Sucker-Punch",
				"Toxic-Spikes",
				"Poison-Jab",
				"Night-Slash",
				"X-Scissor",
				"Shadow-Sneak",
				"Cross-Poison",
				"Captivate",
				"Bug-Bite",
				"Hone-Claws",
				"Venoshock",
				"Rage-Powder",
				"Foul-Play",
				"Round",
				"Struggle-Bug",
				"Electroweb",
				"Sticky-Web",
				"Confide",
				"Infestation",
				"Toxic-Thread",
				"Lunge"
			};
		}
		#endregion
	}
	#endregion

	//Spinarak PokemonInstance Class
	#region Spinarak
	public class SpinarakInstance : PokemonInstance
	{
		#region Spinarak Constructors
		/// <summary>
		/// Spinarak Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public SpinarakInstance(string nickname, int level)
		: base(
				167,
				SpeciesSpinarak.Instance, // Pokemon Species
				nickname, level,
				Bug.Instance, Poison.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Spinarak Builder only waiting for a Level
		/// </summary>
		public SpinarakInstance(int level)
		: base(
				167,
				SpeciesSpinarak.Instance, // PokemonInstance Species
				"Spinarak", level,
				Bug.Instance, Poison.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Spinarak Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public Spinarak() : base(
			167,
			SpeciesSpinarak.Instance, // PokemonInstance Species
			Bug.Instance, Poison.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}