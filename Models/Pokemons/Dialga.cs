using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Dialga Species to store common natural stats of all Dialgas
	#region SpeciesDialga
	public class SpeciesDialga : PokemonSpecies
	{
#nullable enable
		private static SpeciesDialga? _instance = null;
#nullable restore
        public static SpeciesDialga Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesDialga();
                }
                return _instance;
            }
        }

		#region SpeciesDialga Constructor
		public SpeciesDialga() : base(
			"Dialga",
			5.4,
			683.0,
			100, // HPs
			120, 120, // Attack & Defense
			150, 100, // Special Attack & Defense
			90		
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
				"Flash",
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
				"Iron-Tail",
				"Metal-Claw",
				"Hidden-Power",
				"Twister",
				"Rain-Dance",
				"Sunny-Day",
				"Psych-Up",
				"Ancient-Power",
				"Rock-Smash",
				"Facade",
				"Brick-Break",
				"Secret-Power",
				"Hyper-Voice",
				"Overheat",
				"Rock-Tomb",
				"Aerial-Ace",
				"Iron-Defense",
				"Dragon-Claw",
				"Bulk-Up",
				"Shock-Wave",
				"Gravity",
				"Natural-Gift",
				"Metal-Burst",
				"Heal-Block",
				"Magnet-Rise",
				"Aura-Sphere",
				"Dragon-Pulse",
				"Power-Gem",
				"Earth-Power",
				"Giga-Impact",
				"Shadow-Claw",
				"Flash-Cannon",
				"Trick-Room",
				"Draco-Meteor",
				"Iron-Head",
				"Stone-Edge",
				"Stealth-Rock",
				"Roar-Of-Time",
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

	//Dialga PokemonInstance Class
	#region Dialga
	public class DialgaInstance : PokemonInstance
	{
		#region Dialga Constructors
		/// <summary>
		/// Dialga Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public DialgaInstance(string nickname, int level)
		: base(
				483,
				SpeciesDialga.Instance, // Pokemon Species
				nickname, level,
				Steel.Instance, Dragon.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Dialga Builder only waiting for a Level
		/// </summary>
		public DialgaInstance(int level)
		: base(
				483,
				SpeciesDialga.Instance, // PokemonInstance Species
				"Dialga", level,
				Steel.Instance, Dragon.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Dialga Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public Dialga() : base(
			483,
			SpeciesDialga.Instance, // PokemonInstance Species
			Steel.Instance, Dragon.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}