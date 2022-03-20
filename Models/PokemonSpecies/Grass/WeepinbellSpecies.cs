using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Weepinbell Species to store common natural stats of all Weepinbells
	#region WeepinbellSpecies
	public class WeepinbellSpecies : PokemonSpecies
	{
#nullable enable
		private static WeepinbellSpecies? _instance = null;
#nullable restore
        public static WeepinbellSpecies Instance => _instance ?? (_instance = new WeepinbellSpecies());

		#region WeepinbellSpecies Constructor
		public WeepinbellSpecies() : base(
			70,
			"Weepinbell",
			Grass.Instance, Poison.Instance,
			1.0,
			6.4,
			new PokemonStats(
				65, // HPs
				90, 50, // Attack & Defense
				85, 45, // Spacial Attack & Defense
				55 // Speed
			)			
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
				"Wrap",
				"Take-Down",
				"Double-Edge",
				"Acid",
				"Mega-Drain",
				"Growth",
				"Razor-Leaf",
				"Solar-Beam",
				"Poison-Powder",
				"Stun-Spore",
				"Sleep-Powder",
				"Toxic",
				"Rage",
				"Mimic",
				"Double-Team",
				"Reflect",
				"Bide",
				"Flash",
				"Rest",
				"Substitute",
				"Thief",
				"Snore",
				"Curse",
				"Protect",
				"Sludge-Bomb",
				"Giga-Drain",
				"Endure",
				"Swagger",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Sweet-Scent",
				"Synthesis",
				"Hidden-Power",
				"Sunny-Day",
				"Facade",
				"Nature-Power",
				"Knock-Off",
				"Secret-Power",
				"Bullet-Seed",
				"Natural-Gift",
				"Wring-Out",
				"Gastro-Acid",
				"Worry-Seed",
				"Sucker-Punch",
				"Poison-Jab",
				"Seed-Bomb",
				"Energy-Ball",
				"Captivate",
				"Grass-Knot",
				"Bug-Bite",
				"Venoshock",
				"Round",
				"Confide",
				"Infestation"
			};
		}
		#endregion
	}
	#endregion
}