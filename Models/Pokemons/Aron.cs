using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Aron Species to store common natural stats of all Arons
	#region SpeciesAron
	public class SpeciesAron : PokemonSpecies
	{
#nullable enable
		private static SpeciesAron? _instance = null;
#nullable restore
        public static SpeciesAron Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesAron();
                }
                return _instance;
            }
        }

		#region SpeciesAron Constructor
		public SpeciesAron() : base(
			"Aron",
			0.4,
			60.0,
			50, // HPs
			70, 100, // Attack & Defense
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
				"Cut",
				"Stomp",
				"Headbutt",
				"Tackle",
				"Body-Slam",
				"Take-Down",
				"Double-Edge",
				"Roar",
				"Strength",
				"Earthquake",
				"Dig",
				"Toxic",
				"Mimic",
				"Screech",
				"Double-Team",
				"Harden",
				"Defense-Curl",
				"Rest",
				"Rock-Slide",
				"Substitute",
				"Snore",
				"Curse",
				"Reversal",
				"Spite",
				"Protect",
				"Mud-Slap",
				"Sandstorm",
				"Endure",
				"Rollout",
				"Swagger",
				"Fury-Cutter",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Iron-Tail",
				"Metal-Claw",
				"Hidden-Power",
				"Rain-Dance",
				"Sunny-Day",
				"Ancient-Power",
				"Rock-Smash",
				"Uproar",
				"Facade",
				"Smelling-Salts",
				"Superpower",
				"Endeavor",
				"Secret-Power",
				"Rock-Tomb",
				"Metal-Sound",
				"Aerial-Ace",
				"Iron-Defense",
				"Shock-Wave",
				"Water-Pulse",
				"Natural-Gift",
				"Metal-Burst",
				"Magnet-Rise",
				"Rock-Polish",
				"Dragon-Rush",
				"Earth-Power",
				"Shadow-Claw",
				"Iron-Head",
				"Captivate",
				"Stealth-Rock",
				"Head-Smash",
				"Hone-Claws",
				"Autotomize",
				"Heavy-Slam",
				"Round",
				"Bulldoze",
				"Confide"
			};
		}
		#endregion
	}
	#endregion

	//Aron PokemonInstance Class
	#region Aron
	public class AronInstance : PokemonInstance
	{
		#region Aron Constructors
		/// <summary>
		/// Aron Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public AronInstance(string nickname, int level)
		: base(
				304,
				SpeciesAron.Instance, // Pokemon Species
				nickname, level,
				Steel.Instance, Rock.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Aron Builder only waiting for a Level
		/// </summary>
		public AronInstance(int level)
		: base(
				304,
				SpeciesAron.Instance, // PokemonInstance Species
				"Aron", level,
				Steel.Instance, Rock.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Aron Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public Aron() : base(
			304,
			SpeciesAron.Instance, // PokemonInstance Species
			Steel.Instance, Rock.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}