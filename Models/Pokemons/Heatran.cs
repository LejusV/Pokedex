using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Heatran Species to store common natural stats of all Heatrans
	#region SpeciesHeatran
	public class SpeciesHeatran : PokemonSpecies
	{
#nullable enable
		private static SpeciesHeatran? _instance = null;
#nullable restore
        public static SpeciesHeatran Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesHeatran();
                }
                return _instance;
            }
        }

		#region SpeciesHeatran Constructor
		public SpeciesHeatran() : base(
			485,
			"Heatran",
			1.7,
			430.0,
			91, // HPs
			90, 106, // Attack & Defense
			130, 106, // Special Attack & Defense
			77		
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
				"Headbutt",
				"Leer",
				"Roar",
				"Flamethrower",
				"Hyper-Beam",
				"Strength",
				"Solar-Beam",
				"Fire-Spin",
				"Earthquake",
				"Dig",
				"Toxic",
				"Double-Team",
				"Fire-Blast",
				"Explosion",
				"Rest",
				"Rock-Slide",
				"Substitute",
				"Snore",
				"Protect",
				"Scary-Face",
				"Mud-Slap",
				"Endure",
				"Swagger",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Hidden-Power",
				"Sunny-Day",
				"Crunch",
				"Ancient-Power",
				"Rock-Smash",
				"Uproar",
				"Heat-Wave",
				"Torment",
				"Will-O-Wisp",
				"Facade",
				"Nature-Power",
				"Taunt",
				"Secret-Power",
				"Overheat",
				"Rock-Tomb",
				"Metal-Sound",
				"Iron-Defense",
				"Natural-Gift",
				"Payback",
				"Dark-Pulse",
				"Dragon-Pulse",
				"Earth-Power",
				"Giga-Impact",
				"Fire-Fang",
				"Flash-Cannon",
				"Rock-Climb",
				"Lava-Plume",
				"Iron-Head",
				"Stone-Edge",
				"Captivate",
				"Stealth-Rock",
				"Bug-Bite",
				"Magma-Storm",
				"Flame-Charge",
				"Round",
				"Incinerate",
				"Bulldoze",
				"Confide"
			};
		}
		#endregion
	}
	#endregion

	//Heatran PokemonInstance Class
	#region Heatran
	public class HeatranInstance : PokemonInstance
	{
		#region Heatran Constructors
		/// <summary>
		/// Heatran Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public HeatranInstance(string nickname, int level)
		: base(
				SpeciesHeatran.Instance, // Pokemon Species
				nickname, level,
				Fire.Instance, Steel.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Heatran Builder only waiting for a Level
		/// </summary>
		public HeatranInstance(int level)
		: base(
				SpeciesHeatran.Instance, // PokemonInstance Species
				"Heatran", level,
				Fire.Instance, Steel.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Heatran Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public HeatranInstance() : base(
			SpeciesHeatran.Instance, // PokemonInstance Species
			Fire.Instance, Steel.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}