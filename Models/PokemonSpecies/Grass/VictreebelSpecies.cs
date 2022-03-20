using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Victreebel Species to store common natural stats of all Victreebels
	#region VictreebelSpecies
	public class VictreebelSpecies : PokemonSpecies
	{
#nullable enable
		private static VictreebelSpecies? _instance = null;
#nullable restore
        public static VictreebelSpecies Instance => _instance ?? (_instance = new VictreebelSpecies());

		#region VictreebelSpecies Constructor
		public VictreebelSpecies() : base(
			71,
			"Victreebel",
			Grass.Instance, Poison.Instance,
			1.7,
			15.5,
			new PokemonStats(
				80, // HPs
				105, 65, // Attack & Defense
				100, 70, // Spacial Attack & Defense
				70 // Speed
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
				"Vine-Whip",
				"Body-Slam",
				"Wrap",
				"Take-Down",
				"Double-Edge",
				"Acid",
				"Hyper-Beam",
				"Mega-Drain",
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
				"Stockpile",
				"Spit-Up",
				"Swallow",
				"Facade",
				"Nature-Power",
				"Knock-Off",
				"Secret-Power",
				"Bullet-Seed",
				"Leaf-Blade",
				"Natural-Gift",
				"Gastro-Acid",
				"Worry-Seed",
				"Sucker-Punch",
				"Poison-Jab",
				"Seed-Bomb",
				"Energy-Ball",
				"Giga-Impact",
				"Leaf-Storm",
				"Captivate",
				"Grass-Knot",
				"Bug-Bite",
				"Venoshock",
				"Round",
				"Leaf-Tornado",
				"Confide",
				"Infestation"
			};
		}
		#endregion
	}
	#endregion
}