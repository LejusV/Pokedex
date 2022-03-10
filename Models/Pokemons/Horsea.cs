using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Horsea Species to store common natural stats of all Horseas
	#region SpeciesHorsea
	public class SpeciesHorsea : PokemonSpecies
	{
#nullable enable
		private static SpeciesHorsea? _instance = null;
#nullable restore
        public static SpeciesHorsea Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesHorsea();
                }
                return _instance;
            }
        }

		#region SpeciesHorsea Constructor
		public SpeciesHorsea() : base(
			"Horsea",
			0.4,
			8.0,
			30, // HPs
			40, 70, // Attack & Defense
			70, 25, // Special Attack & Defense
			60		
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
				"Headbutt",
				"Take-Down",
				"Double-Edge",
				"Leer",
				"Disable",
				"Water-Gun",
				"Hydro-Pump",
				"Surf",
				"Ice-Beam",
				"Blizzard",
				"Bubble-Beam",
				"Aurora-Beam",
				"Dragon-Rage",
				"Toxic",
				"Agility",
				"Rage",
				"Mimic",
				"Double-Team",
				"Smokescreen",
				"Focus-Energy",
				"Bide",
				"Waterfall",
				"Swift",
				"Skull-Bash",
				"Bubble",
				"Splash",
				"Rest",
				"Substitute",
				"Snore",
				"Curse",
				"Flail",
				"Protect",
				"Octazooka",
				"Icy-Wind",
				"Outrage",
				"Endure",
				"Swagger",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Dragon-Breath",
				"Hidden-Power",
				"Twister",
				"Rain-Dance",
				"Whirlpool",
				"Hail",
				"Facade",
				"Secret-Power",
				"Dive",
				"Signal-Beam",
				"Muddy-Water",
				"Bounce",
				"Dragon-Dance",
				"Water-Pulse",
				"Brine",
				"Natural-Gift",
				"Dragon-Pulse",
				"Flash-Cannon",
				"Captivate",
				"Round",
				"Clear-Smog",
				"Scald",
				"Confide"
			};
		}
		#endregion
	}
	#endregion

	//Horsea PokemonInstance Class
	#region Horsea
	public class HorseaInstance : PokemonInstance
	{
		#region Horsea Constructors
		/// <summary>
		/// Horsea Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public HorseaInstance(string nickname, int level)
		: base(
				116,
				SpeciesHorsea.Instance, // Pokemon Species
				nickname, level,
				Water.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Horsea Builder only waiting for a Level
		/// </summary>
		public HorseaInstance(int level)
		: base(
				116,
				SpeciesHorsea.Instance, // PokemonInstance Species
				"Horsea", level,
				Water.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Horsea Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public Horsea() : base(
			116,
			SpeciesHorsea.Instance, // PokemonInstance Species
			Water.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}