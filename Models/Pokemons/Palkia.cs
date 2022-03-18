using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Palkia Species to store common natural stats of all Palkias
	#region SpeciesPalkia
	public class SpeciesPalkia : PokemonSpecies
	{
#nullable enable
		private static SpeciesPalkia? _instance = null;
#nullable restore
        public static SpeciesPalkia Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesPalkia();
                }
                return _instance;
            }
        }

		#region SpeciesPalkia Constructor
		public SpeciesPalkia() : base(
			484,
			"Palkia",
			4.2,
			336.0,
			90, // HPs
			120, 100, // Attack & Defense
			150, 120, // Special Attack & Defense
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
				"Cut",
				"Headbutt",
				"Roar",
				"Flamethrower",
				"Hydro-Pump",
				"Surf",
				"Ice-Beam",
				"Blizzard",
				"Hyper-Beam",
				"Strength",
				"Thunderbolt",
				"Thunder-Wave",
				"Thunder",
				"Earthquake",
				"Toxic",
				"Double-Team",
				"Fire-Blast",
				"Swift",
				"Rest",
				"Rock-Slide",
				"Slash",
				"Substitute",
				"Snore",
				"Protect",
				"Scary-Face",
				"Mud-Slap",
				"Outrage",
				"Sandstorm",
				"Endure",
				"Swagger",
				"Fury-Cutter",
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
				"Ancient-Power",
				"Rock-Smash",
				"Whirlpool",
				"Hail",
				"Facade",
				"Focus-Punch",
				"Brick-Break",
				"Secret-Power",
				"Dive",
				"Hyper-Voice",
				"Rock-Tomb",
				"Aerial-Ace",
				"Dragon-Claw",
				"Bulk-Up",
				"Shock-Wave",
				"Water-Pulse",
				"Gravity",
				"Brine",
				"Natural-Gift",
				"Fling",
				"Heal-Block",
				"Aqua-Ring",
				"Aura-Sphere",
				"Aqua-Tail",
				"Dragon-Pulse",
				"Power-Gem",
				"Focus-Blast",
				"Earth-Power",
				"Giga-Impact",
				"Avalanche",
				"Shadow-Claw",
				"Trick-Room",
				"Draco-Meteor",
				"Stone-Edge",
				"Spacial-Rend",
				"Hone-Claws",
				"Round",
				"Echoed-Voice",
				"Incinerate",
				"Bulldoze",
				"Dragon-Tail",
				"Confide"
			};
		}
		#endregion
	}
	#endregion

	//Palkia PokemonInstance Class
	#region Palkia
	public class PalkiaInstance : PokemonInstance
	{
		#region Palkia Constructors
		/// <summary>
		/// Palkia Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public PalkiaInstance(string nickname, int level)
		: base(
				SpeciesPalkia.Instance, // Pokemon Species
				nickname, level,
				Water.Instance, Dragon.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Palkia Builder only waiting for a Level
		/// </summary>
		public PalkiaInstance(int level)
		: base(
				SpeciesPalkia.Instance, // PokemonInstance Species
				"Palkia", level,
				Water.Instance, Dragon.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Palkia Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public PalkiaInstance() : base(
			SpeciesPalkia.Instance, // PokemonInstance Species
			Water.Instance, Dragon.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}