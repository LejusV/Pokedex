using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Snivy Species to store common natural stats of all Snivys
	#region SpeciesSnivy
	public class SpeciesSnivy : PokemonSpecies
	{
#nullable enable
		private static SpeciesSnivy? _instance = null;
#nullable restore
        public static SpeciesSnivy Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesSnivy();
                }
                return _instance;
            }
        }

		#region SpeciesSnivy Constructor
		public SpeciesSnivy() : base(
			495,
			"Snivy",
			0.6,
			8.1,
			45, // HPs
			45, 55, // Attack & Defense
			45, 55, // Special Attack & Defense
			63		
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
				"Slam",
				"Vine-Whip",
				"Tackle",
				"Wrap",
				"Leer",
				"Mega-Drain",
				"Leech-Seed",
				"Growth",
				"Solar-Beam",
				"Toxic",
				"Double-Team",
				"Light-Screen",
				"Reflect",
				"Glare",
				"Flash",
				"Rest",
				"Substitute",
				"Snore",
				"Protect",
				"Giga-Drain",
				"Swagger",
				"Mean-Look",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Safeguard",
				"Pursuit",
				"Sweet-Scent",
				"Iron-Tail",
				"Synthesis",
				"Hidden-Power",
				"Twister",
				"Sunny-Day",
				"Mirror-Coat",
				"Torment",
				"Facade",
				"Nature-Power",
				"Taunt",
				"Knock-Off",
				"Snatch",
				"Secret-Power",
				"Aerial-Ace",
				"Magical-Leaf",
				"Calm-Mind",
				"Leaf-Blade",
				"Natural-Gift",
				"Wring-Out",
				"Gastro-Acid",
				"Worry-Seed",
				"Aqua-Tail",
				"Seed-Bomb",
				"Energy-Ball",
				"Leaf-Storm",
				"Captivate",
				"Grass-Knot",
				"Coil",
				"Round",
				"Grass-Pledge",
				"Work-Up",
				"Leaf-Tornado",
				"Grassy-Terrain",
				"Confide"
			};
		}
		#endregion
	}
	#endregion

	//Snivy PokemonInstance Class
	#region Snivy
	public class SnivyInstance : PokemonInstance
	{
		#region Snivy Constructors
		/// <summary>
		/// Snivy Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public SnivyInstance(string nickname, int level)
		: base(
				SpeciesSnivy.Instance, // Pokemon Species
				nickname, level,
				Grass.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Snivy Builder only waiting for a Level
		/// </summary>
		public SnivyInstance(int level)
		: base(
				SpeciesSnivy.Instance, // PokemonInstance Species
				"Snivy", level,
				Grass.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Snivy Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public SnivyInstance() : base(
			SpeciesSnivy.Instance, // PokemonInstance Species
			Grass.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}