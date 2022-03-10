using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Latias Species to store common natural stats of all Latiass
	#region SpeciesLatias
	public class SpeciesLatias : PokemonSpecies
	{
#nullable enable
		private static SpeciesLatias? _instance = null;
#nullable restore
        public static SpeciesLatias Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesLatias();
                }
                return _instance;
            }
        }

		#region SpeciesLatias Constructor
		public SpeciesLatias() : base(
			"Latias",
			1.4,
			40.0,
			80, // HPs
			80, 90, // Attack & Defense
			110, 130, // Special Attack & Defense
			110		
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
				"Fly",
				"Body-Slam",
				"Double-Edge",
				"Roar",
				"Surf",
				"Ice-Beam",
				"Hyper-Beam",
				"Solar-Beam",
				"Thunderbolt",
				"Thunder-Wave",
				"Thunder",
				"Earthquake",
				"Toxic",
				"Psychic",
				"Mimic",
				"Double-Team",
				"Recover",
				"Light-Screen",
				"Reflect",
				"Waterfall",
				"Swift",
				"Dream-Eater",
				"Flash",
				"Psywave",
				"Rest",
				"Substitute",
				"Snore",
				"Protect",
				"Mud-Slap",
				"Icy-Wind",
				"Outrage",
				"Sandstorm",
				"Endure",
				"Charm",
				"Swagger",
				"Fury-Cutter",
				"Steel-Wing",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Safeguard",
				"Dragon-Breath",
				"Hidden-Power",
				"Twister",
				"Rain-Dance",
				"Sunny-Day",
				"Psych-Up",
				"Shadow-Ball",
				"Whirlpool",
				"Facade",
				"Helping-Hand",
				"Trick",
				"Role-Play",
				"Wish",
				"Magic-Coat",
				"Refresh",
				"Secret-Power",
				"Dive",
				"Mist-Ball",
				"Aerial-Ace",
				"Dragon-Claw",
				"Covet",
				"Water-Sport",
				"Calm-Mind",
				"Shock-Wave",
				"Water-Pulse",
				"Roost",
				"Healing-Wish",
				"Natural-Gift",
				"Tailwind",
				"Psycho-Shift",
				"Last-Resort",
				"Sucker-Punch",
				"Dragon-Pulse",
				"Energy-Ball",
				"Giga-Impact",
				"Shadow-Claw",
				"Zen-Headbutt",
				"Defog",
				"Draco-Meteor",
				"Captivate",
				"Grass-Knot",
				"Charge-Beam",
				"Hone-Claws",
				"Guard-Split",
				"Psyshock",
				"Telekinesis",
				"Magic-Room",
				"Round",
				"Stored-Power",
				"Heal-Pulse",
				"Reflect-Type",
				"Retaliate",
				"Bulldoze",
				"Confide"
			};
		}
		#endregion
	}
	#endregion

	//Latias PokemonInstance Class
	#region Latias
	public class LatiasInstance : PokemonInstance
	{
		#region Latias Constructors
		/// <summary>
		/// Latias Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public LatiasInstance(string nickname, int level)
		: base(
				380,
				SpeciesLatias.Instance, // Pokemon Species
				nickname, level,
				Dragon.Instance, Psychic.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Latias Builder only waiting for a Level
		/// </summary>
		public LatiasInstance(int level)
		: base(
				380,
				SpeciesLatias.Instance, // PokemonInstance Species
				"Latias", level,
				Dragon.Instance, Psychic.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Latias Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public Latias() : base(
			380,
			SpeciesLatias.Instance, // PokemonInstance Species
			Dragon.Instance, Psychic.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}