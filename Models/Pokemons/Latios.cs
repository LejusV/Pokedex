using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Latios Species to store common natural stats of all Latioss
	#region SpeciesLatios
	public class SpeciesLatios : PokemonSpecies
	{
#nullable enable
		private static SpeciesLatios? _instance = null;
#nullable restore
        public static SpeciesLatios Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesLatios();
                }
                return _instance;
            }
        }

		#region SpeciesLatios Constructor
		public SpeciesLatios() : base(
			"Latios",
			2.0,
			60.0,
			80, // HPs
			90, 80, // Attack & Defense
			130, 110, // Special Attack & Defense
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
				"Memento",
				"Facade",
				"Helping-Hand",
				"Trick",
				"Magic-Coat",
				"Refresh",
				"Secret-Power",
				"Dive",
				"Luster-Purge",
				"Aerial-Ace",
				"Dragon-Claw",
				"Calm-Mind",
				"Dragon-Dance",
				"Shock-Wave",
				"Water-Pulse",
				"Roost",
				"Natural-Gift",
				"Tailwind",
				"Psycho-Shift",
				"Heal-Block",
				"Last-Resort",
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
				"Power-Split",
				"Wonder-Room",
				"Psyshock",
				"Telekinesis",
				"Round",
				"Stored-Power",
				"Heal-Pulse",
				"Retaliate",
				"Bulldoze",
				"Confide"
			};
		}
		#endregion
	}
	#endregion

	//Latios PokemonInstance Class
	#region Latios
	public class LatiosInstance : PokemonInstance
	{
		#region Latios Constructors
		/// <summary>
		/// Latios Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public LatiosInstance(string nickname, int level)
		: base(
				381,
				SpeciesLatios.Instance, // Pokemon Species
				nickname, level,
				Dragon.Instance, Psychic.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Latios Builder only waiting for a Level
		/// </summary>
		public LatiosInstance(int level)
		: base(
				381,
				SpeciesLatios.Instance, // PokemonInstance Species
				"Latios", level,
				Dragon.Instance, Psychic.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Latios Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public Latios() : base(
			381,
			SpeciesLatios.Instance, // PokemonInstance Species
			Dragon.Instance, Psychic.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}