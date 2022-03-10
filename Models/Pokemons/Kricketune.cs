using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Kricketune Species to store common natural stats of all Kricketunes
	#region SpeciesKricketune
	public class SpeciesKricketune : PokemonSpecies
	{
#nullable enable
		private static SpeciesKricketune? _instance = null;
#nullable restore
        public static SpeciesKricketune Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesKricketune();
                }
                return _instance;
            }
        }

		#region SpeciesKricketune Constructor
		public SpeciesKricketune() : base(
			"Kricketune",
			1.0,
			25.5,
			77, // HPs
			85, 51, // Attack & Defense
			55, 51, // Special Attack & Defense
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
				"Cut",
				"Growl",
				"Sing",
				"Hyper-Beam",
				"Strength",
				"Absorb",
				"String-Shot",
				"Toxic",
				"Screech",
				"Double-Team",
				"Focus-Energy",
				"Bide",
				"Leech-Life",
				"Flash",
				"Rest",
				"Slash",
				"Substitute",
				"Snore",
				"Protect",
				"Mud-Slap",
				"Perish-Song",
				"Endure",
				"False-Swipe",
				"Swagger",
				"Fury-Cutter",
				"Attract",
				"Sleep-Talk",
				"Heal-Bell",
				"Return",
				"Frustration",
				"Hidden-Power",
				"Rain-Dance",
				"Sunny-Day",
				"Rock-Smash",
				"Uproar",
				"Facade",
				"Taunt",
				"Brick-Break",
				"Knock-Off",
				"Endeavor",
				"Secret-Power",
				"Hyper-Voice",
				"Silver-Wind",
				"Aerial-Ace",
				"Natural-Gift",
				"Night-Slash",
				"X-Scissor",
				"Bug-Buzz",
				"Giga-Impact",
				"Captivate",
				"Bug-Bite",
				"Hone-Claws",
				"Round",
				"Echoed-Voice",
				"Struggle-Bug",
				"Sticky-Web",
				"Fell-Stinger",
				"Confide",
				"Infestation",
				"Power-Up-Punch"
			};
		}
		#endregion
	}
	#endregion

	//Kricketune PokemonInstance Class
	#region Kricketune
	public class KricketuneInstance : PokemonInstance
	{
		#region Kricketune Constructors
		/// <summary>
		/// Kricketune Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public KricketuneInstance(string nickname, int level)
		: base(
				402,
				SpeciesKricketune.Instance, // Pokemon Species
				nickname, level,
				Bug.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Kricketune Builder only waiting for a Level
		/// </summary>
		public KricketuneInstance(int level)
		: base(
				402,
				SpeciesKricketune.Instance, // PokemonInstance Species
				"Kricketune", level,
				Bug.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Kricketune Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public Kricketune() : base(
			402,
			SpeciesKricketune.Instance, // PokemonInstance Species
			Bug.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}