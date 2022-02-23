using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Relicanth Specie to store common natural stats of every {'abilities': ['swift-swim', 'rock-head', 'sturdy'], 'base_experience': 170, 'height': 10, 'id': 369, 'moves': ['headbutt', 'tackle', 'body-slam', 'take-down', 'double-edge', 'water-gun', 'hydro-pump', 'surf', 'ice-beam', 'blizzard', 'hyper-beam', 'earthquake', 'toxic', 'mimic', 'double-team', 'harden', 'waterfall', 'skull-bash', 'amnesia', 'rest', 'rock-slide', 'substitute', 'snore', 'flail', 'protect', 'mud-slap', 'icy-wind', 'sandstorm', 'endure', 'swagger', 'attract', 'sleep-talk', 'return', 'frustration', 'safeguard', 'magnitude', 'hidden-power', 'rain-dance', 'psych-up', 'ancient-power', 'rock-smash', 'whirlpool', 'hail', 'facade', 'yawn', 'secret-power', 'dive', 'mud-sport', 'rock-tomb', 'muddy-water', 'bounce', 'mud-shot', 'water-sport', 'calm-mind', 'water-pulse', 'brine', 'natural-gift', 'rock-polish', 'aqua-tail', 'earth-power', 'giga-impact', 'zen-headbutt', 'stone-edge', 'captivate', 'stealth-rock', 'head-smash', 'smack-down', 'round', 'scald', 'bulldoze', 'confide'], 'name': 'relicanth', 'stats': {'hp': 100, 'attack': 90, 'defense': 130, 'special-attack': 45, 'special-defense': 65, 'speed': 55}, 'types': ['water', 'rock'], 'weight': 234, 'is_baby': False, 'is_legendary': False, 'is_mythical': False, 'hatch_counter': 40, 'gender_rate': 1, 'capture_rate': 25, 'color': 'gray', 'shape': 'fish', 'habitat': 'sea', 'generation': 'generation-iii', 'growth_rate': 'slow', 'egg_groups': ['water1', 'water2'], 'names': {'ja-Hrkt': 'ジーランス', 'roomaji': 'Glanth', 'ko': '시라칸', 'zh-Hant': '古空棘魚', 'fr': 'Relicanth', 'de': 'Relicanth', 'es': 'Relicanth', 'it': 'Relicanth', 'en': 'Relicanth', 'ja': 'ジーランス', 'zh-Hans': '古空棘鱼'}, 'genera': {'ja-Hrkt': 'ちょうじゅポケモン', 'ko': '장수포켓몬', 'zh-Hant': '長壽寶可夢', 'fr': 'Pokémon Longévité', 'de': 'Bestand', 'es': 'Pokémon Longevo', 'it': 'Pokémon Longevità', 'en': 'Longevity Pokémon', 'ja': 'ちょうじゅポケモン', 'zh-Hans': '长寿宝可梦'}}
	public class SpecieRelicanth : PokemonSpecie
	{
#nullable enable
		private static SpecieRelicanth? _instance = null;
#nullable restore
        public static SpecieRelicanth Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieRelicanth();
                }
                return _instance;
            }
        }

		public SpecieRelicanth() : base(
			"Relicanth",
			100, // HPs
			90, 130, // Attack & Defense
			45, 65, // Special Attack & Defense
			55			
		) {}
	}


	//Relicanth Pokemon Class
	public class Relicanth : Pokemon
	{

		public Relicanth(string nickname, int level) : base(
			369,
			SpecieRelicanth.Instance, // Pokemon Specie
			nickname, level,
			Water.Instance, Rock.Instance			
		) {}

		public Relicanth() : base(
			369,
			SpecieRelicanth.Instance, // Pokemon Specie
			Water.Instance, Rock.Instance			
		) {}
	}
}