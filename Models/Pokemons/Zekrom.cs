using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Zekrom Species to store common natural stats of all Zekroms
	#region SpeciesZekrom
	public class SpeciesZekrom : PokemonSpecies
	{
#nullable enable
		private static SpeciesZekrom? _instance = null;
#nullable restore
        public static SpeciesZekrom Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesZekrom();
                }
                return _instance;
            }
        }

		#region SpeciesZekrom Constructor
		public SpeciesZekrom() : base(
			"Zekrom",
			2.9,
			345.0,
			100, // HPs
			150, 120, // Attack & Defense
			120, 100, // Special Attack & Defense
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
				"Thunder-Punch",
				"Cut",
				"Fly",
				"Hyper-Beam",
				"Strength",
				"Dragon-Rage",
				"Thunderbolt",
				"Thunder-Wave",
				"Thunder",
				"Toxic",
				"Psychic",
				"Double-Team",
				"Light-Screen",
				"Reflect",
				"Flash",
				"Rest",
				"Rock-Slide",
				"Slash",
				"Substitute",
				"Snore",
				"Protect",
				"Outrage",
				"Swagger",
				"Steel-Wing",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Safeguard",
				"Dragon-Breath",
				"Hidden-Power",
				"Rain-Dance",
				"Crunch",
				"Ancient-Power",
				"Shadow-Ball",
				"Rock-Smash",
				"Facade",
				"Imprison",
				"Secret-Power",
				"Hyper-Voice",
				"Rock-Tomb",
				"Signal-Beam",
				"Dragon-Claw",
				"Shock-Wave",
				"Roost",
				"Tailwind",
				"Payback",
				"Fling",
				"Magnet-Rise",
				"Dragon-Pulse",
				"Focus-Blast",
				"Earth-Power",
				"Giga-Impact",
				"Shadow-Claw",
				"Thunder-Fang",
				"Zen-Headbutt",
				"Flash-Cannon",
				"Draco-Meteor",
				"Stone-Edge",
				"Charge-Beam",
				"Hone-Claws",
				"Round",
				"Echoed-Voice",
				"Volt-Switch",
				"Dragon-Tail",
				"Wild-Charge",
				"Bolt-Strike",
				"Fusion-Bolt",
				"Noble-Roar",
				"Confide",
				"Brutal-Swing"
			};
		}
		#endregion
	}
	#endregion

	//Zekrom PokemonInstance Class
	#region Zekrom
	public class ZekromInstance : PokemonInstance
	{
		#region Zekrom Constructors
		/// <summary>
		/// Zekrom Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public ZekromInstance(string nickname, int level)
		: base(
				644,
				SpeciesZekrom.Instance, // Pokemon Species
				nickname, level,
				Dragon.Instance, Electric.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Zekrom Builder only waiting for a Level
		/// </summary>
		public ZekromInstance(int level)
		: base(
				644,
				SpeciesZekrom.Instance, // PokemonInstance Species
				"Zekrom", level,
				Dragon.Instance, Electric.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Zekrom Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public Zekrom() : base(
			644,
			SpeciesZekrom.Instance, // PokemonInstance Species
			Dragon.Instance, Electric.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}