using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Vibrava Species to store common natural stats of all Vibravas
	#region SpeciesVibrava
	public class SpeciesVibrava : PokemonSpecies
	{
#nullable enable
		private static SpeciesVibrava? _instance = null;
#nullable restore
        public static SpeciesVibrava Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesVibrava();
                }
                return _instance;
            }
        }

		#region SpeciesVibrava Constructor
		public SpeciesVibrava() : base(
			329,
			"Vibrava",
			1.1,
			15.3,
			50, // HPs
			70, 50, // Attack & Defense
			50, 50, // Special Attack & Defense
			70		
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
				"Fly",
				"Sand-Attack",
				"Headbutt",
				"Body-Slam",
				"Double-Edge",
				"Bite",
				"Supersonic",
				"Sonic-Boom",
				"Hyper-Beam",
				"Strength",
				"Solar-Beam",
				"Earthquake",
				"Dig",
				"Toxic",
				"Mimic",
				"Screech",
				"Double-Team",
				"Bide",
				"Swift",
				"Rest",
				"Rock-Slide",
				"Substitute",
				"Snore",
				"Protect",
				"Feint-Attack",
				"Mud-Slap",
				"Outrage",
				"Sandstorm",
				"Giga-Drain",
				"Endure",
				"Swagger",
				"Fury-Cutter",
				"Steel-Wing",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Dragon-Breath",
				"Hidden-Power",
				"Twister",
				"Sunny-Day",
				"Crunch",
				"Rock-Smash",
				"Uproar",
				"Heat-Wave",
				"Facade",
				"Superpower",
				"Secret-Power",
				"Air-Cutter",
				"Rock-Tomb",
				"Silver-Wind",
				"Signal-Beam",
				"Sand-Tomb",
				"Roost",
				"Natural-Gift",
				"Tailwind",
				"U-Turn",
				"Bug-Buzz",
				"Dragon-Pulse",
				"Earth-Power",
				"Defog",
				"Draco-Meteor",
				"Captivate",
				"Bug-Bite",
				"Ominous-Wind",
				"Round",
				"Struggle-Bug",
				"Bulldoze",
				"Boomburst",
				"Confide"
			};
		}
		#endregion
	}
	#endregion

	//Vibrava PokemonInstance Class
	#region Vibrava
	public class VibravaInstance : PokemonInstance
	{
		#region Vibrava Constructors
		/// <summary>
		/// Vibrava Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public VibravaInstance(string nickname, int level)
		: base(
				SpeciesVibrava.Instance, // Pokemon Species
				nickname, level,
				Ground.Instance, Dragon.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Vibrava Builder only waiting for a Level
		/// </summary>
		public VibravaInstance(int level)
		: base(
				SpeciesVibrava.Instance, // PokemonInstance Species
				"Vibrava", level,
				Ground.Instance, Dragon.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Vibrava Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public VibravaInstance() : base(
			SpeciesVibrava.Instance, // PokemonInstance Species
			Ground.Instance, Dragon.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}