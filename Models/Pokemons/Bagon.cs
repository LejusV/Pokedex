using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Bagon Species to store common natural stats of all Bagons
	#region SpeciesBagon
	public class SpeciesBagon : PokemonSpecies
	{
#nullable enable
		private static SpeciesBagon? _instance = null;
#nullable restore
        public static SpeciesBagon Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesBagon();
                }
                return _instance;
            }
        }

		#region SpeciesBagon Constructor
		public SpeciesBagon() : base(
			371,
			"Bagon",
			0.6,
			42.1,
			45, // HPs
			75, 60, // Attack & Defense
			40, 30, // Special Attack & Defense
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
				"Thrash",
				"Double-Edge",
				"Leer",
				"Bite",
				"Roar",
				"Ember",
				"Flamethrower",
				"Hydro-Pump",
				"Strength",
				"Dragon-Rage",
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
				"Dragon-Claw",
				"Dragon-Dance",
				"Natural-Gift",
				"Dragon-Pulse",
				"Dragon-Rush",
				"Shadow-Claw",
				"Fire-Fang",
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

	//Bagon PokemonInstance Class
	#region Bagon
	public class BagonInstance : PokemonInstance
	{
		#region Bagon Constructors
		/// <summary>
		/// Bagon Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public BagonInstance(string nickname, int level)
		: base(
				SpeciesBagon.Instance, // Pokemon Species
				nickname, level,
				Dragon.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Bagon Builder only waiting for a Level
		/// </summary>
		public BagonInstance(int level)
		: base(
				SpeciesBagon.Instance, // PokemonInstance Species
				"Bagon", level,
				Dragon.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Bagon Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public BagonInstance() : base(
			SpeciesBagon.Instance, // PokemonInstance Species
			Dragon.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}