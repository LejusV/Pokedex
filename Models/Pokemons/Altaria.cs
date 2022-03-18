using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Altaria Species to store common natural stats of all Altarias
	#region SpeciesAltaria
	public class SpeciesAltaria : PokemonSpecies
	{
#nullable enable
		private static SpeciesAltaria? _instance = null;
#nullable restore
        public static SpeciesAltaria Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesAltaria();
                }
                return _instance;
            }
        }

		#region SpeciesAltaria Constructor
		public SpeciesAltaria() : base(
			334,
			"Altaria",
			1.1,
			20.6,
			75, // HPs
			70, 90, // Attack & Defense
			70, 105, // Special Attack & Defense
			80		
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
				"Fury-Attack",
				"Body-Slam",
				"Take-Down",
				"Double-Edge",
				"Growl",
				"Roar",
				"Sing",
				"Flamethrower",
				"Mist",
				"Ice-Beam",
				"Hyper-Beam",
				"Peck",
				"Solar-Beam",
				"Earthquake",
				"Toxic",
				"Mimic",
				"Double-Team",
				"Fire-Blast",
				"Swift",
				"Dream-Eater",
				"Sky-Attack",
				"Rest",
				"Substitute",
				"Thief",
				"Snore",
				"Protect",
				"Mud-Slap",
				"Perish-Song",
				"Outrage",
				"Endure",
				"Swagger",
				"Steel-Wing",
				"Attract",
				"Sleep-Talk",
				"Heal-Bell",
				"Return",
				"Frustration",
				"Safeguard",
				"Dragon-Breath",
				"Iron-Tail",
				"Hidden-Power",
				"Twister",
				"Rain-Dance",
				"Sunny-Day",
				"Psych-Up",
				"Rock-Smash",
				"Uproar",
				"Heat-Wave",
				"Facade",
				"Refresh",
				"Secret-Power",
				"Hyper-Voice",
				"Astonish",
				"Air-Cutter",
				"Aerial-Ace",
				"Dragon-Claw",
				"Dragon-Dance",
				"Roost",
				"Natural-Gift",
				"Pluck",
				"Tailwind",
				"Dragon-Pulse",
				"Giga-Impact",
				"Draco-Meteor",
				"Captivate",
				"Ominous-Wind",
				"Hone-Claws",
				"Wonder-Room",
				"Round",
				"Echoed-Voice",
				"Incinerate",
				"Bulldoze",
				"Cotton-Guard",
				"Disarming-Voice",
				"Moonblast",
				"Confide",
				"Dazzling-Gleam"
			};
		}
		#endregion
	}
	#endregion

	//Altaria PokemonInstance Class
	#region Altaria
	public class AltariaInstance : PokemonInstance
	{
		#region Altaria Constructors
		/// <summary>
		/// Altaria Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public AltariaInstance(string nickname, int level)
		: base(
				SpeciesAltaria.Instance, // Pokemon Species
				nickname, level,
				Dragon.Instance, Flying.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Altaria Builder only waiting for a Level
		/// </summary>
		public AltariaInstance(int level)
		: base(
				SpeciesAltaria.Instance, // PokemonInstance Species
				"Altaria", level,
				Dragon.Instance, Flying.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Altaria Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public AltariaInstance() : base(
			SpeciesAltaria.Instance, // PokemonInstance Species
			Dragon.Instance, Flying.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}