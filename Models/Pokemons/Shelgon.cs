using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Shelgon Species to store common natural stats of all Shelgons
	#region SpeciesShelgon
	public class SpeciesShelgon : PokemonSpecies
	{
#nullable enable
		private static SpeciesShelgon? _instance = null;
#nullable restore
        public static SpeciesShelgon Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesShelgon();
                }
                return _instance;
            }
        }

		#region SpeciesShelgon Constructor
		public SpeciesShelgon() : base(
			"Shelgon",
			1.1,
			110.5,
			65, // HPs
			95, 100, // Attack & Defense
			60, 50, // Special Attack & Defense
			50		
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
				"Headbutt",
				"Body-Slam",
				"Double-Edge",
				"Leer",
				"Bite",
				"Roar",
				"Ember",
				"Flamethrower",
				"Strength",
				"Toxic",
				"Rage",
				"Mimic",
				"Double-Team",
				"Defense-Curl",
				"Focus-Energy",
				"Fire-Blast",
				"Rest",
				"Rock-Slide",
				"Substitute",
				"Snore",
				"Protect",
				"Scary-Face",
				"Mud-Slap",
				"Outrage",
				"Endure",
				"Rollout",
				"Swagger",
				"Fury-Cutter",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Dragon-Breath",
				"Hidden-Power",
				"Twister",
				"Rain-Dance",
				"Sunny-Day",
				"Crunch",
				"Rock-Smash",
				"Facade",
				"Brick-Break",
				"Secret-Power",
				"Hyper-Voice",
				"Rock-Tomb",
				"Aerial-Ace",
				"Iron-Defense",
				"Dragon-Claw",
				"Natural-Gift",
				"Dragon-Pulse",
				"Shadow-Claw",
				"Zen-Headbutt",
				"Draco-Meteor",
				"Captivate",
				"Hone-Claws",
				"Round",
				"Incinerate",
				"Confide"
			};
		}
		#endregion
	}
	#endregion

	//Shelgon PokemonInstance Class
	#region Shelgon
	public class ShelgonInstance : PokemonInstance
	{
		#region Shelgon Constructors
		/// <summary>
		/// Shelgon Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public ShelgonInstance(string nickname, int level)
		: base(
				372,
				SpeciesShelgon.Instance, // Pokemon Species
				nickname, level,
				Dragon.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Shelgon Builder only waiting for a Level
		/// </summary>
		public ShelgonInstance(int level)
		: base(
				372,
				SpeciesShelgon.Instance, // PokemonInstance Species
				"Shelgon", level,
				Dragon.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Shelgon Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public Shelgon() : base(
			372,
			SpeciesShelgon.Instance, // PokemonInstance Species
			Dragon.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}