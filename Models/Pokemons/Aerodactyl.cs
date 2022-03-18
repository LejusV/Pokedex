using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Aerodactyl Species to store common natural stats of all Aerodactyls
	#region SpeciesAerodactyl
	public class SpeciesAerodactyl : PokemonSpecies
	{
#nullable enable
		private static SpeciesAerodactyl? _instance = null;
#nullable restore
        public static SpeciesAerodactyl Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesAerodactyl();
                }
                return _instance;
            }
        }

		#region SpeciesAerodactyl Constructor
		public SpeciesAerodactyl() : base(
			142,
			"Aerodactyl",
			1.8,
			59.0,
			80, // HPs
			105, 65, // Attack & Defense
			60, 75, // Special Attack & Defense
			130		
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
				"Razor-Wind",
				"Wing-Attack",
				"Whirlwind",
				"Fly",
				"Headbutt",
				"Take-Down",
				"Double-Edge",
				"Bite",
				"Roar",
				"Supersonic",
				"Flamethrower",
				"Hyper-Beam",
				"Strength",
				"Dragon-Rage",
				"Earthquake",
				"Toxic",
				"Agility",
				"Rage",
				"Mimic",
				"Double-Team",
				"Reflect",
				"Bide",
				"Fire-Blast",
				"Swift",
				"Sky-Attack",
				"Rest",
				"Rock-Slide",
				"Substitute",
				"Thief",
				"Snore",
				"Curse",
				"Protect",
				"Scary-Face",
				"Foresight",
				"Detect",
				"Sandstorm",
				"Endure",
				"Swagger",
				"Steel-Wing",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Dragon-Breath",
				"Pursuit",
				"Iron-Tail",
				"Hidden-Power",
				"Twister",
				"Rain-Dance",
				"Sunny-Day",
				"Crunch",
				"Ancient-Power",
				"Rock-Smash",
				"Heat-Wave",
				"Torment",
				"Facade",
				"Taunt",
				"Secret-Power",
				"Air-Cutter",
				"Rock-Tomb",
				"Aerial-Ace",
				"Dragon-Claw",
				"Roost",
				"Natural-Gift",
				"Tailwind",
				"Payback",
				"Assurance",
				"Rock-Polish",
				"Aqua-Tail",
				"Dragon-Pulse",
				"Earth-Power",
				"Giga-Impact",
				"Thunder-Fang",
				"Ice-Fang",
				"Fire-Fang",
				"Defog",
				"Iron-Head",
				"Stone-Edge",
				"Captivate",
				"Stealth-Rock",
				"Ominous-Wind",
				"Hone-Claws",
				"Wide-Guard",
				"Smack-Down",
				"Round",
				"Sky-Drop",
				"Incinerate",
				"Bulldoze",
				"Confide",
				"Brutal-Swing"
			};
		}
		#endregion
	}
	#endregion

	//Aerodactyl PokemonInstance Class
	#region Aerodactyl
	public class AerodactylInstance : PokemonInstance
	{
		#region Aerodactyl Constructors
		/// <summary>
		/// Aerodactyl Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public AerodactylInstance(string nickname, int level)
		: base(
				SpeciesAerodactyl.Instance, // Pokemon Species
				nickname, level,
				Rock.Instance, Flying.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Aerodactyl Builder only waiting for a Level
		/// </summary>
		public AerodactylInstance(int level)
		: base(
				SpeciesAerodactyl.Instance, // PokemonInstance Species
				"Aerodactyl", level,
				Rock.Instance, Flying.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Aerodactyl Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public AerodactylInstance() : base(
			SpeciesAerodactyl.Instance, // PokemonInstance Species
			Rock.Instance, Flying.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}