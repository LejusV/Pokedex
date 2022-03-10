using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Flygon Species to store common natural stats of all Flygons
	#region SpeciesFlygon
	public class SpeciesFlygon : PokemonSpecies
	{
#nullable enable
		private static SpeciesFlygon? _instance = null;
#nullable restore
        public static SpeciesFlygon Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesFlygon();
                }
                return _instance;
            }
        }

		#region SpeciesFlygon Constructor
		public SpeciesFlygon() : base(
			"Flygon",
			2.0,
			82.0,
			80, // HPs
			100, 80, // Attack & Defense
			80, 80, // Special Attack & Defense
			100		
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
				"Fire-Punch",
				"Thunder-Punch",
				"Fly",
				"Sand-Attack",
				"Headbutt",
				"Body-Slam",
				"Double-Edge",
				"Bite",
				"Supersonic",
				"Sonic-Boom",
				"Flamethrower",
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
				"Fire-Blast",
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
				"Iron-Tail",
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
				"Aerial-Ace",
				"Dragon-Claw",
				"Dragon-Dance",
				"Roost",
				"Natural-Gift",
				"Tailwind",
				"U-Turn",
				"Dragon-Pulse",
				"Dragon-Rush",
				"Earth-Power",
				"Giga-Impact",
				"Defog",
				"Draco-Meteor",
				"Stone-Edge",
				"Captivate",
				"Bug-Bite",
				"Ominous-Wind",
				"Hone-Claws",
				"Round",
				"Incinerate",
				"Struggle-Bug",
				"Bulldoze",
				"Dragon-Tail",
				"Confide",
				"Power-Up-Punch",
				"Brutal-Swing"
			};
		}
		#endregion
	}
	#endregion

	//Flygon PokemonInstance Class
	#region Flygon
	public class FlygonInstance : PokemonInstance
	{
		#region Flygon Constructors
		/// <summary>
		/// Flygon Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public FlygonInstance(string nickname, int level)
		: base(
				330,
				SpeciesFlygon.Instance, // Pokemon Species
				nickname, level,
				Ground.Instance, Dragon.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Flygon Builder only waiting for a Level
		/// </summary>
		public FlygonInstance(int level)
		: base(
				330,
				SpeciesFlygon.Instance, // PokemonInstance Species
				"Flygon", level,
				Ground.Instance, Dragon.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Flygon Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public Flygon() : base(
			330,
			SpeciesFlygon.Instance, // PokemonInstance Species
			Ground.Instance, Dragon.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}