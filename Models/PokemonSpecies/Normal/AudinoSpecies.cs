using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Audino Species to store common natural stats of all Audinos
	#region AudinoSpecies
	public class AudinoSpecies : PokemonSpecies
	{
#nullable enable
		private static AudinoSpecies? _instance = null;
#nullable restore
        public static AudinoSpecies Instance => _instance ?? (_instance = new AudinoSpecies());

		#region AudinoSpecies Constructor
		public AudinoSpecies() : base(
			531,
			"Audino",
			Normal.Instance,
			1.1,
			31.0,
			new PokemonStats(
				103, // HPs
				60, 86, // Attack & Defense
				60, 86, // Spacial Attack & Defense
				50 // Speed
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
				"Pound",
				"Double-Slap",
				"Fire-Punch",
				"Ice-Punch",
				"Thunder-Punch",
				"Take-Down",
				"Double-Edge",
				"Growl",
				"Flamethrower",
				"Surf",
				"Ice-Beam",
				"Blizzard",
				"Hyper-Beam",
				"Low-Kick",
				"Solar-Beam",
				"Thunderbolt",
				"Thunder-Wave",
				"Thunder",
				"Dig",
				"Toxic",
				"Psychic",
				"Double-Team",
				"Light-Screen",
				"Reflect",
				"Fire-Blast",
				"Amnesia",
				"Dream-Eater",
				"Flash",
				"Rest",
				"Substitute",
				"Snore",
				"Protect",
				"Sweet-Kiss",
				"Icy-Wind",
				"Swagger",
				"Attract",
				"Sleep-Talk",
				"Heal-Bell",
				"Return",
				"Frustration",
				"Safeguard",
				"Pain-Split",
				"Encore",
				"Iron-Tail",
				"Hidden-Power",
				"Rain-Dance",
				"Sunny-Day",
				"Psych-Up",
				"Shadow-Ball",
				"Uproar",
				"Facade",
				"Focus-Punch",
				"Helping-Hand",
				"Role-Play",
				"Wish",
				"Magic-Coat",
				"Yawn",
				"Knock-Off",
				"Skill-Swap",
				"Refresh",
				"Snatch",
				"Secret-Power",
				"Hyper-Voice",
				"Signal-Beam",
				"Covet",
				"Calm-Mind",
				"Gravity",
				"Healing-Wish",
				"Fling",
				"Lucky-Chant",
				"Last-Resort",
				"Drain-Punch",
				"Zen-Headbutt",
				"Trick-Room",
				"Grass-Knot",
				"Charge-Beam",
				"Psyshock",
				"Telekinesis",
				"Simple-Beam",
				"Entrainment",
				"After-You",
				"Round",
				"Echoed-Voice",
				"Heal-Pulse",
				"Incinerate",
				"Retaliate",
				"Bestow",
				"Work-Up",
				"Wild-Charge",
				"Disarming-Voice",
				"Draining-Kiss",
				"Misty-Terrain",
				"Play-Nice",
				"Confide",
				"Dazzling-Gleam",
				"Baby-Doll-Eyes",
				"Power-Up-Punch"
			};
		}
		#endregion
	}
	#endregion
}