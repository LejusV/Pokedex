using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Tentacruel Species to store common natural stats of all Tentacruels
	#region SpeciesTentacruel
	public class SpeciesTentacruel : PokemonSpecies
	{
#nullable enable
		private static SpeciesTentacruel? _instance = null;
#nullable restore
        public static SpeciesTentacruel Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesTentacruel();
                }
                return _instance;
            }
        }

		#region SpeciesTentacruel Constructor
		public SpeciesTentacruel() : base(
			73,
			"Tentacruel",
			1.6,
			55.0,
			80, // HPs
			70, 65, // Attack & Defense
			80, 120, // Special Attack & Defense
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
				"Swords-Dance",
				"Cut",
				"Bind",
				"Wrap",
				"Take-Down",
				"Double-Edge",
				"Poison-Sting",
				"Supersonic",
				"Acid",
				"Water-Gun",
				"Hydro-Pump",
				"Surf",
				"Ice-Beam",
				"Blizzard",
				"Bubble-Beam",
				"Hyper-Beam",
				"Mega-Drain",
				"Toxic",
				"Rage",
				"Mimic",
				"Screech",
				"Double-Team",
				"Barrier",
				"Reflect",
				"Bide",
				"Waterfall",
				"Skull-Bash",
				"Constrict",
				"Rest",
				"Substitute",
				"Thief",
				"Snore",
				"Curse",
				"Protect",
				"Sludge-Bomb",
				"Icy-Wind",
				"Giga-Drain",
				"Endure",
				"Swagger",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Safeguard",
				"Hidden-Power",
				"Rain-Dance",
				"Whirlpool",
				"Hail",
				"Facade",
				"Magic-Coat",
				"Knock-Off",
				"Secret-Power",
				"Dive",
				"Water-Pulse",
				"Brine",
				"Natural-Gift",
				"Payback",
				"Wring-Out",
				"Toxic-Spikes",
				"Poison-Jab",
				"Giga-Impact",
				"Captivate",
				"Venoshock",
				"Sludge-Wave",
				"Acid-Spray",
				"Round",
				"Scald",
				"Hex",
				"Reflect-Type",
				"Confide",
				"Dazzling-Gleam",
				"Infestation"
			};
		}
		#endregion
	}
	#endregion

	//Tentacruel PokemonInstance Class
	#region Tentacruel
	public class TentacruelInstance : PokemonInstance
	{
		#region Tentacruel Constructors
		/// <summary>
		/// Tentacruel Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public TentacruelInstance(string nickname, int level)
		: base(
				SpeciesTentacruel.Instance, // Pokemon Species
				nickname, level,
				Water.Instance, Poison.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Tentacruel Builder only waiting for a Level
		/// </summary>
		public TentacruelInstance(int level)
		: base(
				SpeciesTentacruel.Instance, // PokemonInstance Species
				"Tentacruel", level,
				Water.Instance, Poison.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Tentacruel Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public TentacruelInstance() : base(
			SpeciesTentacruel.Instance, // PokemonInstance Species
			Water.Instance, Poison.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}