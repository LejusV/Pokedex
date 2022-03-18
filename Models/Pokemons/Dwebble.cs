using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Dwebble Species to store common natural stats of all Dwebbles
	#region SpeciesDwebble
	public class SpeciesDwebble : PokemonSpecies
	{
#nullable enable
		private static SpeciesDwebble? _instance = null;
#nullable restore
        public static SpeciesDwebble Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesDwebble();
                }
                return _instance;
            }
        }

		#region SpeciesDwebble Constructor
		public SpeciesDwebble() : base(
			557,
			"Dwebble",
			0.3,
			14.5,
			50, // HPs
			65, 85, // Attack & Defense
			35, 35, // Special Attack & Defense
			55		
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
				"Sand-Attack",
				"Counter",
				"Strength",
				"Solar-Beam",
				"Earthquake",
				"Dig",
				"Toxic",
				"Double-Team",
				"Withdraw",
				"Rest",
				"Rock-Slide",
				"Slash",
				"Substitute",
				"Snore",
				"Curse",
				"Flail",
				"Protect",
				"Feint-Attack",
				"Spikes",
				"Sandstorm",
				"Endure",
				"Swagger",
				"Fury-Cutter",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Hidden-Power",
				"Rock-Smash",
				"Facade",
				"Nature-Power",
				"Knock-Off",
				"Secret-Power",
				"Rock-Tomb",
				"Sand-Tomb",
				"Aerial-Ace",
				"Iron-Defense",
				"Block",
				"Rock-Blast",
				"Rock-Polish",
				"Poison-Jab",
				"Night-Slash",
				"X-Scissor",
				"Shadow-Claw",
				"Rock-Wrecker",
				"Stone-Edge",
				"Stealth-Rock",
				"Bug-Bite",
				"Hone-Claws",
				"Wide-Guard",
				"Smack-Down",
				"Round",
				"Shell-Smash",
				"Struggle-Bug",
				"Bulldoze",
				"Rototiller",
				"Confide"
			};
		}
		#endregion
	}
	#endregion

	//Dwebble PokemonInstance Class
	#region Dwebble
	public class DwebbleInstance : PokemonInstance
	{
		#region Dwebble Constructors
		/// <summary>
		/// Dwebble Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public DwebbleInstance(string nickname, int level)
		: base(
				SpeciesDwebble.Instance, // Pokemon Species
				nickname, level,
				Bug.Instance, Rock.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Dwebble Builder only waiting for a Level
		/// </summary>
		public DwebbleInstance(int level)
		: base(
				SpeciesDwebble.Instance, // PokemonInstance Species
				"Dwebble", level,
				Bug.Instance, Rock.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Dwebble Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public DwebbleInstance() : base(
			SpeciesDwebble.Instance, // PokemonInstance Species
			Bug.Instance, Rock.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}