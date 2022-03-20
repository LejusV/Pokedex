using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Magmar Species to store common natural stats of all Magmars
	#region MagmarSpecies
	public class MagmarSpecies : PokemonSpecies
	{
#nullable enable
		private static MagmarSpecies? _instance = null;
#nullable restore
        public static MagmarSpecies Instance => _instance ?? (_instance = new MagmarSpecies());

		#region MagmarSpecies Constructor
		public MagmarSpecies() : base(
			126,
			"Magmar",
			Fire.Instance,
			1.3,
			44.5,
			new PokemonStats(
				65, // HPs
				95, 57, // Attack & Defense
				100, 85, // Spacial Attack & Defense
				93 // Speed
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
				"Mega-Punch",
				"Fire-Punch",
				"Thunder-Punch",
				"Mega-Kick",
				"Headbutt",
				"Body-Slam",
				"Take-Down",
				"Double-Edge",
				"Leer",
				"Ember",
				"Flamethrower",
				"Hyper-Beam",
				"Submission",
				"Low-Kick",
				"Counter",
				"Seismic-Toss",
				"Strength",
				"Fire-Spin",
				"Toxic",
				"Psychic",
				"Rage",
				"Teleport",
				"Mimic",
				"Double-Team",
				"Smokescreen",
				"Confuse-Ray",
				"Bide",
				"Metronome",
				"Smog",
				"Fire-Blast",
				"Skull-Bash",
				"Psywave",
				"Rest",
				"Substitute",
				"Thief",
				"Snore",
				"Curse",
				"Protect",
				"Feint-Attack",
				"Mud-Slap",
				"Detect",
				"Endure",
				"Swagger",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Dynamic-Punch",
				"Iron-Tail",
				"Hidden-Power",
				"Sunny-Day",
				"Rock-Smash",
				"Heat-Wave",
				"Will-O-Wisp",
				"Facade",
				"Focus-Punch",
				"Helping-Hand",
				"Brick-Break",
				"Secret-Power",
				"Overheat",
				"Covet",
				"Natural-Gift",
				"Fling",
				"Focus-Blast",
				"Giga-Impact",
				"Rock-Climb",
				"Lava-Plume",
				"Captivate",
				"Flame-Burst",
				"Flame-Charge",
				"Low-Sweep",
				"Round",
				"Clear-Smog",
				"Incinerate",
				"Dual-Chop",
				"Confide",
				"Power-Up-Punch"
			};
		}
		#endregion
	}
	#endregion
}