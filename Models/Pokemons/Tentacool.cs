using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Tentacool Species to store common natural stats of all Tentacools
	#region SpeciesTentacool
	public class SpeciesTentacool : PokemonSpecies
	{
#nullable enable
		private static SpeciesTentacool? _instance = null;
#nullable restore
        public static SpeciesTentacool Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesTentacool();
                }
                return _instance;
            }
        }

		#region SpeciesTentacool Constructor
		public SpeciesTentacool() : base(
			72,
			"Tentacool",
			0.9,
			45.5,
			40, // HPs
			40, 35, // Attack & Defense
			50, 100, // Special Attack & Defense
			70		
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
				"Aurora-Beam",
				"Mega-Drain",
				"Toxic",
				"Rage",
				"Mimic",
				"Screech",
				"Double-Team",
				"Confuse-Ray",
				"Barrier",
				"Haze",
				"Reflect",
				"Bide",
				"Waterfall",
				"Skull-Bash",
				"Constrict",
				"Bubble",
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
				"Rapid-Spin",
				"Hidden-Power",
				"Rain-Dance",
				"Mirror-Coat",
				"Whirlpool",
				"Hail",
				"Facade",
				"Magic-Coat",
				"Knock-Off",
				"Secret-Power",
				"Dive",
				"Tickle",
				"Muddy-Water",
				"Water-Pulse",
				"Brine",
				"Natural-Gift",
				"Acupressure",
				"Payback",
				"Wring-Out",
				"Toxic-Spikes",
				"Aqua-Ring",
				"Poison-Jab",
				"Captivate",
				"Venoshock",
				"Sludge-Wave",
				"Acid-Spray",
				"Round",
				"Scald",
				"Hex",
				"Confide",
				"Dazzling-Gleam",
				"Infestation"
			};
		}
		#endregion
	}
	#endregion

	//Tentacool PokemonInstance Class
	#region Tentacool
	public class TentacoolInstance : PokemonInstance
	{
		#region Tentacool Constructors
		/// <summary>
		/// Tentacool Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public TentacoolInstance(string nickname, int level)
		: base(
				SpeciesTentacool.Instance, // Pokemon Species
				nickname, level,
				Water.Instance, Poison.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Tentacool Builder only waiting for a Level
		/// </summary>
		public TentacoolInstance(int level)
		: base(
				SpeciesTentacool.Instance, // PokemonInstance Species
				"Tentacool", level,
				Water.Instance, Poison.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Tentacool Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public TentacoolInstance() : base(
			SpeciesTentacool.Instance, // PokemonInstance Species
			Water.Instance, Poison.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}