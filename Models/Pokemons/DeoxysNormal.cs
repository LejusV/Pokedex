using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Deoxys-Normal Species to store common natural stats of all Deoxys-Normals
	#region SpeciesDeoxys-Normal
	public class SpeciesDeoxysNormal : PokemonSpecies
	{
#nullable enable
		private static SpeciesDeoxysNormal? _instance = null;
#nullable restore
        public static SpeciesDeoxysNormal Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesDeoxysNormal();
                }
                return _instance;
            }
        }

		#region SpeciesDeoxys-Normal Constructor
		public SpeciesDeoxysNormal() : base(
			"Deoxys-Normal",
			1.7,
			60.8,
			50, // HPs
			150, 50, // Attack & Defense
			150, 50, // Special Attack & Defense
			150		
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
				"Ice-Punch",
				"Thunder-Punch",
				"Cut",
				"Bind",
				"Headbutt",
				"Body-Slam",
				"Wrap",
				"Double-Edge",
				"Leer",
				"Ice-Beam",
				"Hyper-Beam",
				"Low-Kick",
				"Seismic-Toss",
				"Strength",
				"Solar-Beam",
				"Thunderbolt",
				"Thunder-Wave",
				"Thunder",
				"Toxic",
				"Psychic",
				"Teleport",
				"Night-Shade",
				"Mimic",
				"Double-Team",
				"Recover",
				"Light-Screen",
				"Reflect",
				"Swift",
				"Dream-Eater",
				"Flash",
				"Rest",
				"Rock-Slide",
				"Substitute",
				"Nightmare",
				"Snore",
				"Protect",
				"Mud-Slap",
				"Icy-Wind",
				"Endure",
				"Swagger",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Safeguard",
				"Pursuit",
				"Hidden-Power",
				"Rain-Dance",
				"Sunny-Day",
				"Psych-Up",
				"Shadow-Ball",
				"Rock-Smash",
				"Torment",
				"Facade",
				"Focus-Punch",
				"Taunt",
				"Trick",
				"Role-Play",
				"Magic-Coat",
				"Recycle",
				"Brick-Break",
				"Knock-Off",
				"Skill-Swap",
				"Snatch",
				"Secret-Power",
				"Rock-Tomb",
				"Cosmic-Power",
				"Signal-Beam",
				"Aerial-Ace",
				"Calm-Mind",
				"Shock-Wave",
				"Water-Pulse",
				"Psycho-Boost",
				"Gravity",
				"Natural-Gift",
				"Fling",
				"Psycho-Shift",
				"Poison-Jab",
				"Dark-Pulse",
				"Drain-Punch",
				"Focus-Blast",
				"Energy-Ball",
				"Giga-Impact",
				"Avalanche",
				"Zen-Headbutt",
				"Flash-Cannon",
				"Trick-Room",
				"Stealth-Rock",
				"Grass-Knot",
				"Charge-Beam",
				"Wonder-Room",
				"Psyshock",
				"Telekinesis",
				"Low-Sweep",
				"Round",
				"Ally-Switch",
				"Confide",
				"Power-Up-Punch",
				"Brutal-Swing"
			};
		}
		#endregion
	}
	#endregion

	//Deoxys-Normal PokemonInstance Class
	#region Deoxys-Normal
	public class DeoxysNormalInstance : PokemonInstance
	{
		#region Deoxys-Normal Constructors
		/// <summary>
		/// Deoxys-Normal Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public DeoxysNormalInstance(string nickname, int level)
		: base(
				386,
				SpeciesDeoxysNormal.Instance, // Pokemon Species
				nickname, level,
				Psychic.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Deoxys-Normal Builder only waiting for a Level
		/// </summary>
		public DeoxysNormalInstance(int level)
		: base(
				386,
				SpeciesDeoxysNormal.Instance, // PokemonInstance Species
				"Deoxys-Normal", level,
				Psychic.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Deoxys-Normal Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public DeoxysNormal() : base(
			386,
			SpeciesDeoxysNormal.Instance, // PokemonInstance Species
			Psychic.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}