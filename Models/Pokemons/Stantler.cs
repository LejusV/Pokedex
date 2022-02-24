using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Stantler Specie to store common natural stats of every {'abilities': ['intimidate', 'frisk', 'sap-sipper'], 'base_experience': 163, 'height': 14, 'id': 234, 'moves': ['stomp', 'double-kick', 'jump-kick', 'sand-attack', 'headbutt', 'tackle', 'body-slam', 'take-down', 'thrash', 'double-edge', 'leer', 'bite', 'roar', 'disable', 'solar-beam', 'thunderbolt', 'thunder-wave', 'thunder', 'earthquake', 'toxic', 'psychic', 'hypnosis', 'rage', 'mimic', 'double-team', 'confuse-ray', 'light-screen', 'reflect', 'swift', 'dream-eater', 'flash', 'rest', 'substitute', 'thief', 'nightmare', 'snore', 'curse', 'spite', 'protect', 'mud-slap', 'detect', 'endure', 'swagger', 'attract', 'sleep-talk', 'return', 'frustration', 'megahorn', 'iron-tail', 'hidden-power', 'rain-dance', 'sunny-day', 'psych-up', 'shadow-ball', 'uproar', 'facade', 'role-play', 'skill-swap', 'imprison', 'secret-power', 'mud-sport', 'astonish', 'signal-beam', 'extrasensory', 'bounce', 'calm-mind', 'shock-wave', 'gravity', 'natural-gift', 'me-first', 'last-resort', 'sucker-punch', 'energy-ball', 'giga-impact', 'zen-headbutt', 'trick-room', 'captivate', 'charge-beam', 'psyshock', 'magic-room', 'round', 'retaliate', 'bulldoze', 'work-up', 'wild-charge', 'confide'], 'name': 'stantler', 'stats': {'hp': 73, 'attack': 95, 'defense': 62, 'special-attack': 85, 'special-defense': 65, 'speed': 85}, 'types': ['normal'], 'weight': 712, 'is_baby': False, 'is_legendary': False, 'is_mythical': False, 'hatch_counter': 20, 'gender_rate': 4, 'capture_rate': 45, 'color': 'brown', 'shape': 'quadruped', 'habitat': 'forest', 'generation': 'generation-ii', 'growth_rate': 'slow', 'egg_groups': ['ground'], 'names': {'ja-Hrkt': 'オドシシ', 'roomaji': 'Odoshishi', 'ko': '노라키', 'zh-Hant': '驚角鹿', 'fr': 'Cerfrousse', 'de': 'Damhirplex', 'es': 'Stantler', 'it': 'Stantler', 'en': 'Stantler', 'ja': 'オドシシ', 'zh-Hans': '惊角鹿'}, 'genera': {'ja-Hrkt': 'おおツノポケモン', 'ko': '큰뿔포켓몬', 'zh-Hant': '大角寶可夢', 'fr': 'Pokémon Maxi Corne', 'de': 'Vielender', 'es': 'Pokémon Gran Cuerno', 'it': 'Pokémon Grancorno', 'en': 'Big Horn Pokémon', 'ja': 'おおツノポケモン', 'zh-Hans': '大角宝可梦'}}
	public class SpecieStantler : PokemonSpecie
	{
#nullable enable
		private static SpecieStantler? _instance = null;
#nullable restore
        public static SpecieStantler Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieStantler();
                }
                return _instance;
            }
        }

		public SpecieStantler() : base(
			"Stantler",
			73, // HPs
			95, 62, // Attack & Defense
			85, 65, // Special Attack & Defense
			85			
		) {}
	}


	//Stantler Pokemon Class
	public class Stantler : Pokemon
	{

		public Stantler(string nickname, int level)
		: base(
				234,
				SpecieStantler.Instance, // Pokemon Specie
				nickname, level,
				Normal.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public Stantler(int level)
		: base(
				234,
				SpecieStantler.Instance, // Pokemon Specie
				"Stantler", level,
				Normal.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public Stantler() : base(
			234,
			SpecieStantler.Instance, // Pokemon Specie
			Normal.Instance			
		) {}
	}
}